using Masuit.Tools;
using System;
using System.Drawing;
using System.IO.Ports;
using System.Text;
using System.Windows.Forms;
using System.Linq;
using System.Threading;
using System.Collections.Generic;

namespace SerialPortAssistant
{
    public partial class SerialPortAssistant : DevExpress.XtraEditors.XtraForm
    {
        private Thread loopThread;

        public SerialPortAssistant()
        {
            InitializeComponent();
            InitAppStart();

            this.MaximumSize = this.Size;
            this.MinimumSize = this.Size;

            this.txtInputData.LostFocus += new EventHandler((obj, ex) =>
            {
                var str = this.txtInputData.Text;
                if (string.IsNullOrWhiteSpace(str))
                {
                    this.txtInputData.ForeColor = Color.Gray;
                    this.txtInputData.Text = "请输入需要发送的内容";
                }
            });

            this.txtInputData.GotFocus += new EventHandler((obj, ex) =>
            {
                var str = this.txtInputData.Text;
                if (str == "请输入需要发送的内容")
                {
                    this.txtInputData.Text = "";
                    this.txtInputData.ForeColor = Color.Black;
                }
            });
        }

        /// <summary>
        /// 初始化应用启动
        /// </summary>
        private void InitAppStart() 
        {
            // 串口
            this.comboBoxEditPortName.Properties.Items.AddRange(SerialPort.GetPortNames());
            if (this.comboBoxEditPortName.Properties.Items.Count == 0)
            {
                this.btnOpenSerialPort.Enabled = false;
                this.memoEditShowLog.AppendText($"未检测到串口 请检查设备是否插入或接口是否松动 {Environment.NewLine}");
            }
            else 
            { 
                this.comboBoxEditPortName.SelectedIndex = 0;
            }
            // 波特率
            this.comboBoxEditBaudRate.Properties.Items.AddRange(new int[] { 300, 600, 1200, 2400, 4800, 9600, 19200, 38400, 43000, 56000, 57600, 115200 });
            this.comboBoxEditBaudRate.SelectedIndex = this.comboBoxEditBaudRate.Properties.Items.IndexOf(this.serialPort.BaudRate);
            // 效验位
            this.comboBoxEditParity.Properties.Items.AddRange(Enum.GetNames(typeof(Parity)));
            this.comboBoxEditParity.SelectedIndex = this.comboBoxEditParity.Properties.Items.IndexOf(this.serialPort.Parity.ToString());
            // 数据位
            this.comboBoxEditDataBits.Properties.Items.AddRange(new int[] { 5, 6, 7, 8 });
            this.comboBoxEditDataBits.SelectedIndex = this.comboBoxEditDataBits.Properties.Items.IndexOf(this.serialPort.DataBits);
            // 停止位
            this.comboBoxEditStopBits.Properties.Items.AddRange(Enum.GetNames(typeof(StopBits)));
            this.comboBoxEditStopBits.SelectedIndex = this.comboBoxEditStopBits.Properties.Items.IndexOf(this.serialPort.StopBits.ToString());

        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            if (!this.serialPort.IsOpen)
            {
                MessageBox.Show("未打开串口连接无法发送数据");
                return;
            }

            if (this.loopThread != null)
            {
                this.loopThread.Abort();
                this.loopThread = null;
                this.btnSend.Text = "发送";
            }
            else
            {
                var str = this.txtInputData.Text.Trim();
                if (string.IsNullOrWhiteSpace(str) || str == "请输入需要发送的内容")
                {
                    MessageBox.Show("发送内容不能为空", "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    if (this.chkSendLoop.Checked)
                    {
                        this.btnSend.Text = "停止发送";
                        this.loopThread = new Thread(() => 
                        {
                            while (true) 
                            {

                                if (this.chkSendHex.Checked)
                                {
                                    var bytes = this.StrToToHexByte(str);
                                    this.serialPort.Write(bytes, 0, bytes.Length);
                                    this.Invoke(new Action(() => this.memoEditShowLog.AppendText(FormatLogShow(string.Join(" ", bytes.Select(x => x.ToString("X2"))), isSend: true))));
                                }
                                else
                                {
                                    this.serialPort.Write(str);
                                    this.Invoke(new Action(() => this.memoEditShowLog.AppendText(FormatLogShow(str, isSend: true))));
                                }

                                Thread.Sleep(this.txtSendLoopMsec.Text.ToInt32());
                            }
                        });
                        loopThread.Start();
                    }
                    else
                    {
                        if (this.chkSendHex.Checked)
                        {
                            var bytes = this.StrToToHexByte(str);
                            this.serialPort.Write(bytes, 0, bytes.Length);
                            this.memoEditShowLog.AppendText(FormatLogShow(string.Join(" ", bytes.Select(x => x.ToString("X2"))), isSend: true));
                        }
                        else
                        {
                            this.serialPort.Write(str);
                            this.memoEditShowLog.AppendText(FormatLogShow(str, isSend: true));
                        }
                    }
                }
            }
        }
        
        private void btnOpenSerialPort_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.serialPort.IsOpen)
                {
                    this.serialPort.Close();
                    this.serialPort.Dispose();
                    this.memoEditShowLog.AppendText(FormatLogShow("连接已关闭", simple: true));
                    this.btnOpenSerialPort.Text = "打开连接";
                }
                else
                {
                    this.serialPort.PortName = this.comboBoxEditPortName.Text;
                    this.serialPort.BaudRate = this.comboBoxEditBaudRate.Text.ToInt32();
                    this.serialPort.DataBits = this.comboBoxEditDataBits.Text.ToInt32();
                    if (Enum.TryParse<Parity>(this.comboBoxEditParity.Text, out var parity)) this.serialPort.Parity = parity;
                    if (Enum.TryParse<StopBits>(this.comboBoxEditStopBits.Text, out var stopBits)) this.serialPort.StopBits = stopBits;
                    this.serialPort.Open();
                    this.memoEditShowLog.AppendText(FormatLogShow("连接已打开", simple: true));
                    this.btnOpenSerialPort.Text = "关闭连接";
                }
            }
            catch (Exception ex)
            {
                this.memoEditShowLog.Text = FormatLogShow(ex.Message, simple: true);
            }
        }

        private void serialPort_DataReceived(object _sender, SerialDataReceivedEventArgs e)
        {
            var sender = _sender as SerialPort;
            var lent = sender.BytesToRead;
            var buffers = new byte[lent];
            sender.Read(buffers, 0, lent);
            var str = Encoding.UTF8.GetString(buffers);
            if (this.chkReceiveHex.Checked) str = string.Join(" ", buffers.Select(b => b.ToString("X2")));
            this.Invoke(new Action(() => this.memoEditShowLog.AppendText(FormatLogShow(str))));
        }

        private void btnClearLog_Click(object sender, EventArgs e)
        {
            this.memoEditShowLog.Text = "";
        }

        private string FormatLogShow(string str, bool simple = false, bool isSend = false) 
        {
            if (!this.chkReceiveLog.Checked) return $"{Environment.NewLine}{str} {Environment.NewLine}";
            if (simple) return $"{Environment.NewLine} [{DateTime.Now:yyyy-MM-dd HH:mm:ss}] {Environment.NewLine} {str} {Environment.NewLine}";
            string dataType = "ASCII";
            if ((isSend && this.chkSendHex.Checked) || (!isSend && this.chkReceiveHex.Checked)) dataType = "HEX";
            return $"{Environment.NewLine} [{DateTime.Now:yyyy-MM-dd HH:mm:ss}] # {(isSend ? "发送" : "接收")} {dataType} {Environment.NewLine} {str} {Environment.NewLine}";
        }

        /// <summary>
        /// 字符串转16进制字节数组
        /// </summary>
        /// <param name="hexString"></param>
        /// <returns></returns>
        private byte[] StrToToHexByte(string hexString)
        {
            hexString = hexString.Replace(" ", "");
            var bytes = new List<byte>();
            for (var i = 0; i < hexString.Length; i += 2)
            {
                var str = hexString.Substring(i, Math.Min(2, hexString.Length - i));
                if (str.Length == 1) str = "0" + str;
                bytes.Add(Convert.ToByte(str, 16));
            }
            return bytes.ToArray();
        }

    }
}
