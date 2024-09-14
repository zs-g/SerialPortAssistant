using System.IO.Ports;
using CommunityToolkit.Mvvm.ComponentModel;

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
        }

        /// <summary>
        /// 波特率
        /// </summary>
        [ObservableProperty]
        private int _baudRate;

        /// <summary>
        /// 数据位
        /// </summary>
        [ObservableProperty]
        private int _dataBits;

        /// <summary>
        /// 停止位
        /// </summary>
        [ObservableProperty]
        private int _stopBits;

        /// <summary>
        /// 校验位
        /// </summary>
        [ObservableProperty]
        private int _parity;

        /// <summary>
        /// 串口名称
        /// </summary>
        [ObservableProperty]
        private string _portName;

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
    }
}
