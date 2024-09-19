using System.IO.Ports;
using System.Windows.Threading;
using CommunityToolkit.Mvvm.Input;
using CommunityToolkit.Mvvm.ComponentModel;
using System.Windows;
using System.Text;

namespace SerialPortAssistant.ViewsModels
{
    public partial class SerialPortViewModel : ObservableValidator
    {
        private readonly Dispatcher _dispatcher;
        private readonly SerialPort _serialPort;
        private List<string> _receiveContentList = [];

        public SerialPortViewModel(Dispatcher dispatcher)
        {
            _dispatcher = dispatcher;
            _serialPort = new SerialPort();
            // 默认波特率
            _baudRate = this._serialPort.BaudRate;
            // 默认数据位
            _dataBits = this._serialPort.DataBits;
            // 默认停止位
            _stopBits = (int)this._serialPort.StopBits;
            // 默认校验位
            _parity = (int)this._serialPort.Parity;
            // 默认串口名称
            // _portName = this._serialPort.PortName;

            if (!SerialPort.GetPortNames().Any())
            {
                this.ContentText = $"未检测到串口, 请检查设备是否连接或驱动是否正确安装。";
            }

            WatchSerialPort();

            this._serialPort.DataReceived += (s, e) =>
            {
                var sp = s as SerialPort;
                var byt = new byte[sp.BytesToRead];
                sp.Read(byt, 0, byt.Length);
                if(this.ReceiveType == "HEX") this.ContentText = BitConverter.ToString(byt).Replace("-", " ");
                else this.ContentText = Encoding.ASCII.GetString(byt);
            };
        }

        /// <summary>
        /// 收发数据
        /// </summary>
        private string _contentText;
        public string ContentText
        {
            get => this._contentText;
            set
            {
                if (string.IsNullOrWhiteSpace(value) && this._receiveContentList.Count == 0)
                {
                    SetProperty(ref _contentText, "");
                    return;
                }
                if (this.LogShow) value = $"{DateTime.Now:yyyy-MM-dd HH:mm:ss}\r\n{value}";
                this._receiveContentList.Add(value);
                SetProperty(ref _contentText, string.Join("\r\n\r\n", this._receiveContentList));
            }
        }

        /// <summary>
        /// 波特率
        /// </summary>
        private int _baudRate;
        public int BaudRate {
            get => _baudRate;
            set
            {
                this._serialPort.BaudRate = value;
                SetProperty(ref _baudRate, value);
            }
        }

        /// <summary>
        /// 数据位
        /// </summary>
        private int _dataBits;
        public int DataBits {
            get => _dataBits;
            set
            {
                this._serialPort.DataBits = value;
                SetProperty(ref _dataBits, value);
            }
        }

        /// <summary>
        /// 停止位
        /// </summary>
        private int _stopBits;
        public int StopBits
        {
            get => _stopBits;
            set
            {
                this._serialPort.StopBits = (StopBits)value;
                SetProperty(ref _stopBits, value);
            }
        }

        /// <summary>
        /// 校验位
        /// </summary>
        private int _parity;
        public int Parity
        {
            get => _parity;
            set
            {
                this._serialPort.Parity = (Parity)value;
                SetProperty(ref _parity, value);
            }
        }

        /// <summary>
        /// 串口名称
        /// </summary>
        private string _portName;
        public string PortName
        {
            get => _portName;
            set
            {
                if (!string.IsNullOrWhiteSpace(value))
                {
                    this._serialPort.PortName = value;
                    SetProperty(ref _portName, value);
                }
            }
        }

        /// <summary>
        /// 按钮显示
        /// </summary>
        [ObservableProperty]
        private string _btnText = "打开串口";

        /// <summary>
        /// 输入内容
        /// </summary>
        [ObservableProperty]
        private string _inputContent;

        /// <summary>
        /// COM口列表
        /// </summary>
        [ObservableProperty]
        private IEnumerable<string> _portNameList;

        /// <summary>
        /// 接收类型
        /// </summary>
        [ObservableProperty]
        private string _receiveType = "ASCII";

        /// <summary>
        /// 波特率列表
        /// </summary>
        public IEnumerable<int> BaudRateList { get; } = [300, 600, 1200, 2400, 4800, 9600, 14400, 19200, 38400, 57600, 115200, 128000, 256000];

        /// <summary>
        /// 校验位列表
        /// </summary>
        public IEnumerable<int> ParityList { get; } = Enum.GetValues<Parity>().Select(p => (int)p);

        /// <summary>
        /// 数据位列表
        /// </summary>
        public IEnumerable<int> DataBitsList { get; } = [5, 6, 7, 8];

        /// <summary>
        /// 停止位列表
        /// </summary>
        public IEnumerable<int> StopBitsList { get; } = Enum.GetValues<StopBits>().Select(s => (int)s);

        /// <summary>
        /// 按照日志显示
        /// </summary>
        [ObservableProperty]
        private bool _logShow = true;

        /// <summary>
        /// 是否打开串口
        /// </summary>
        [ObservableProperty]
        private bool _isSerialPort;

        /// <summary>
        /// 串口开关
        /// </summary>
        [RelayCommand(CanExecute = nameof(IsSerialPort))]
        public void Switch()
        {
            if (this._serialPort.IsOpen)
            {
                this._serialPort.Close();
                this.BtnText = "打开串口";
                this.ContentText = "连接已关闭";
            }
            else
            {
                this._serialPort.Open();
                this.BtnText = "关闭串口";
                this.ContentText = "连接已打开";
            }
        }

        /// <summary>
        /// 清楚显示内容
        /// </summary>
        [RelayCommand]
        public void ClearShowData()
        {
            this._receiveContentList.Clear();
            this.ContentText = "";
            //SetProperty(ref _contentText, "开始清空了");
        }

        /// <summary>
        /// 监听电脑串口插拔
        /// </summary>
        private void WatchSerialPort()
        {
            var thread = new Thread(() =>
            {
                while (true)
                {
                    try
                    {
                        // 使用 Dispatcher 将 UI 更新委托到主线程
                        this._dispatcher?.Invoke(() =>
                        {
                            this.PortNameList = SerialPort.GetPortNames();
                            if (this.PortNameList.Any() != this.IsSerialPort)
                            {
                                if (this.PortNameList.Any()) this.ContentText = "串口已经插入";
                                else this.ContentText = "串口已拔出";
                            }
                            this.IsSerialPort = this.PortNameList.Any();
                            this.SwitchCommand.NotifyCanExecuteChanged();
                        });
                        Thread.Sleep(1000);
                    }
                    catch (Exception ex)
                    {
                    }
                }
            });
            thread.Start();
        }

        /// <summary>
        /// 发送数据
        /// </summary>
        [RelayCommand]
        public void Send() 
        {
            if (!this._serialPort.IsOpen)
            {
                MessageBox.Show("链接还未打开 无法发送数据信息");
                return;
            }
            var str = this.InputContent;
            if (!string.IsNullOrWhiteSpace(str))
            {
                this.ContentText = str.Trim();
                this._serialPort.Write(this.InputContent.Trim());

                return;
            }
            MessageBox.Show("发送内容不可为空");
        }





    }
}
