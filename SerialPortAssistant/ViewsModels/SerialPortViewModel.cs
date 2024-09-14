using System.IO.Ports;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

namespace SerialPortAssistant.ViewsModels
{
    public partial class SerialPortViewModel : ObservableValidator
    {
        private readonly SerialPort _serialPort;

        public SerialPortViewModel()
        {
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
            _portName = this._serialPort.PortName;
            // 是否打开串口
            this.IsSerialPort = SerialPort.GetPortNames().Length > 0;
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
        public int  DataBits { 
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
                this._serialPort.PortName = value;
                SetProperty(ref _portName, value);
            }
        }

        /// <summary>
        /// COM口列表
        /// </summary>
        public IEnumerable<string> PortNameList { get; } = SerialPort.GetPortNames();

        /// <summary>
        /// 波特率列表
        /// </summary>
        public IEnumerable<int> BaudRateList { get;} = [300, 600, 1200, 2400, 4800, 9600, 14400, 19200, 38400, 57600, 115200, 128000, 256000];

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
        /// 是否打开串口
        /// </summary>
        [ObservableProperty]
        [NotifyCanExecuteChangedFor(nameof(SwitchCommand))]
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
            }
            else
            {
                this._serialPort.Open();
            }
        }
        
    }
}
