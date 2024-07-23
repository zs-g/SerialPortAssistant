namespace SerialPortAssistant
{
    partial class SerialPortAssistant
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SerialPortAssistant));
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.groupControl3 = new DevExpress.XtraEditors.GroupControl();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.txtSendLoopMsec = new DevExpress.XtraEditors.TextEdit();
            this.chkSendLoop = new DevExpress.XtraEditors.CheckEdit();
            this.chkSendRandom = new DevExpress.XtraEditors.CheckEdit();
            this.chkSendHex = new DevExpress.XtraEditors.CheckEdit();
            this.chkSendAscii = new DevExpress.XtraEditors.CheckEdit();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.btnClearLog = new DevExpress.XtraEditors.SimpleButton();
            this.chkReceiveScrolling = new DevExpress.XtraEditors.CheckEdit();
            this.chkReceiveSaveFile = new DevExpress.XtraEditors.CheckEdit();
            this.chkReceiveLog = new DevExpress.XtraEditors.CheckEdit();
            this.chkReceiveHex = new DevExpress.XtraEditors.CheckEdit();
            this.chkReceiveAscii = new DevExpress.XtraEditors.CheckEdit();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.btnOpenSerialPort = new DevExpress.XtraEditors.SimpleButton();
            this.comboBoxEditStopBits = new DevExpress.XtraEditors.ComboBoxEdit();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.comboBoxEditDataBits = new DevExpress.XtraEditors.ComboBoxEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.comboBoxEditParity = new DevExpress.XtraEditors.ComboBoxEdit();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.comboBoxEditBaudRate = new DevExpress.XtraEditors.ComboBoxEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.comboBoxEditPortName = new DevExpress.XtraEditors.ComboBoxEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
            this.btnSend = new DevExpress.XtraEditors.SimpleButton();
            this.txtInputData = new DevExpress.XtraEditors.MemoEdit();
            this.groupControl4 = new DevExpress.XtraEditors.GroupControl();
            this.memoEditShowLog = new DevExpress.XtraEditors.MemoEdit();
            this.serialPort = new System.IO.Ports.SerialPort(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl3)).BeginInit();
            this.groupControl3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtSendLoopMsec.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkSendLoop.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkSendRandom.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkSendHex.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkSendAscii.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chkReceiveScrolling.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkReceiveSaveFile.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkReceiveLog.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkReceiveHex.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkReceiveAscii.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.comboBoxEditStopBits.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.comboBoxEditDataBits.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.comboBoxEditParity.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.comboBoxEditBaudRate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.comboBoxEditPortName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            this.panelControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtInputData.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl4)).BeginInit();
            this.groupControl4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.memoEditShowLog.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.groupControl3);
            this.panelControl1.Controls.Add(this.groupControl2);
            this.panelControl1.Controls.Add(this.groupControl1);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelControl1.Location = new System.Drawing.Point(0, 0);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(228, 726);
            this.panelControl1.TabIndex = 0;
            // 
            // groupControl3
            // 
            this.groupControl3.Controls.Add(this.labelControl7);
            this.groupControl3.Controls.Add(this.txtSendLoopMsec);
            this.groupControl3.Controls.Add(this.chkSendLoop);
            this.groupControl3.Controls.Add(this.chkSendRandom);
            this.groupControl3.Controls.Add(this.chkSendHex);
            this.groupControl3.Controls.Add(this.chkSendAscii);
            this.groupControl3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupControl3.Location = new System.Drawing.Point(2, 552);
            this.groupControl3.Name = "groupControl3";
            this.groupControl3.Size = new System.Drawing.Size(224, 172);
            this.groupControl3.TabIndex = 2;
            this.groupControl3.Text = "发送设置";
            // 
            // labelControl7
            // 
            this.labelControl7.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.labelControl7.Appearance.Options.UseFont = true;
            this.labelControl7.Location = new System.Drawing.Point(189, 132);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(17, 16);
            this.labelControl7.TabIndex = 8;
            this.labelControl7.Text = "ms";
            // 
            // txtSendLoopMsec
            // 
            this.txtSendLoopMsec.EditValue = "1000";
            this.txtSendLoopMsec.Location = new System.Drawing.Point(108, 127);
            this.txtSendLoopMsec.Name = "txtSendLoopMsec";
            this.txtSendLoopMsec.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F);
            this.txtSendLoopMsec.Properties.Appearance.Options.UseFont = true;
            this.txtSendLoopMsec.Properties.Appearance.Options.UseTextOptions = true;
            this.txtSendLoopMsec.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.txtSendLoopMsec.Size = new System.Drawing.Size(75, 26);
            this.txtSendLoopMsec.TabIndex = 6;
            // 
            // chkSendLoop
            // 
            this.chkSendLoop.Location = new System.Drawing.Point(21, 128);
            this.chkSendLoop.Name = "chkSendLoop";
            this.chkSendLoop.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F);
            this.chkSendLoop.Properties.Appearance.Options.UseFont = true;
            this.chkSendLoop.Properties.Caption = "循环周期";
            this.chkSendLoop.Size = new System.Drawing.Size(89, 23);
            this.chkSendLoop.TabIndex = 5;
            // 
            // chkSendRandom
            // 
            this.chkSendRandom.Location = new System.Drawing.Point(21, 85);
            this.chkSendRandom.Name = "chkSendRandom";
            this.chkSendRandom.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F);
            this.chkSendRandom.Properties.Appearance.Options.UseFont = true;
            this.chkSendRandom.Properties.Caption = "生成随机数";
            this.chkSendRandom.Size = new System.Drawing.Size(181, 23);
            this.chkSendRandom.TabIndex = 4;
            // 
            // chkSendHex
            // 
            this.chkSendHex.Location = new System.Drawing.Point(127, 42);
            this.chkSendHex.Name = "chkSendHex";
            this.chkSendHex.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F);
            this.chkSendHex.Properties.Appearance.Options.UseFont = true;
            this.chkSendHex.Properties.Caption = "HEX";
            this.chkSendHex.Properties.CheckBoxOptions.Style = DevExpress.XtraEditors.Controls.CheckBoxStyle.Radio;
            this.chkSendHex.Properties.RadioGroupIndex = 1;
            this.chkSendHex.Size = new System.Drawing.Size(75, 23);
            this.chkSendHex.TabIndex = 3;
            this.chkSendHex.TabStop = false;
            // 
            // chkSendAscii
            // 
            this.chkSendAscii.EditValue = true;
            this.chkSendAscii.Location = new System.Drawing.Point(21, 42);
            this.chkSendAscii.Name = "chkSendAscii";
            this.chkSendAscii.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F);
            this.chkSendAscii.Properties.Appearance.Options.UseFont = true;
            this.chkSendAscii.Properties.Caption = "ASCII";
            this.chkSendAscii.Properties.CheckBoxOptions.Style = DevExpress.XtraEditors.Controls.CheckBoxStyle.Radio;
            this.chkSendAscii.Properties.RadioGroupIndex = 1;
            this.chkSendAscii.Size = new System.Drawing.Size(75, 23);
            this.chkSendAscii.TabIndex = 2;
            // 
            // groupControl2
            // 
            this.groupControl2.Controls.Add(this.btnClearLog);
            this.groupControl2.Controls.Add(this.chkReceiveScrolling);
            this.groupControl2.Controls.Add(this.chkReceiveSaveFile);
            this.groupControl2.Controls.Add(this.chkReceiveLog);
            this.groupControl2.Controls.Add(this.chkReceiveHex);
            this.groupControl2.Controls.Add(this.chkReceiveAscii);
            this.groupControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl2.Location = new System.Drawing.Point(2, 304);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(224, 420);
            this.groupControl2.TabIndex = 1;
            this.groupControl2.Text = "接收设置";
            // 
            // btnClearLog
            // 
            this.btnClearLog.Appearance.Font = new System.Drawing.Font("Tahoma", 12F);
            this.btnClearLog.Appearance.Options.UseFont = true;
            this.btnClearLog.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.btnClearLog.ImageOptions.ImageToTextIndent = 6;
            this.btnClearLog.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.btnClearLog.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("simpleButton2.ImageOptions.SvgImage")));
            this.btnClearLog.ImageOptions.SvgImageSize = new System.Drawing.Size(20, 20);
            this.btnClearLog.Location = new System.Drawing.Point(17, 197);
            this.btnClearLog.Name = "btnClearLog";
            this.btnClearLog.Size = new System.Drawing.Size(192, 36);
            this.btnClearLog.TabIndex = 11;
            this.btnClearLog.Text = "清空数据日志";
            this.btnClearLog.Click += new System.EventHandler(this.btnClearLog_Click);
            // 
            // chkReceiveScrolling
            // 
            this.chkReceiveScrolling.Location = new System.Drawing.Point(21, 164);
            this.chkReceiveScrolling.Name = "chkReceiveScrolling";
            this.chkReceiveScrolling.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F);
            this.chkReceiveScrolling.Properties.Appearance.Options.UseFont = true;
            this.chkReceiveScrolling.Properties.Caption = "自动滚屏";
            this.chkReceiveScrolling.Size = new System.Drawing.Size(181, 23);
            this.chkReceiveScrolling.TabIndex = 4;
            // 
            // chkReceiveSaveFile
            // 
            this.chkReceiveSaveFile.Location = new System.Drawing.Point(21, 125);
            this.chkReceiveSaveFile.Name = "chkReceiveSaveFile";
            this.chkReceiveSaveFile.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F);
            this.chkReceiveSaveFile.Properties.Appearance.Options.UseFont = true;
            this.chkReceiveSaveFile.Properties.Caption = "接收保存到文件";
            this.chkReceiveSaveFile.Size = new System.Drawing.Size(181, 23);
            this.chkReceiveSaveFile.TabIndex = 3;
            // 
            // chkReceiveLog
            // 
            this.chkReceiveLog.EditValue = true;
            this.chkReceiveLog.Location = new System.Drawing.Point(21, 86);
            this.chkReceiveLog.Name = "chkReceiveLog";
            this.chkReceiveLog.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F);
            this.chkReceiveLog.Properties.Appearance.Options.UseFont = true;
            this.chkReceiveLog.Properties.Caption = "按日志模式显示";
            this.chkReceiveLog.Size = new System.Drawing.Size(181, 23);
            this.chkReceiveLog.TabIndex = 2;
            // 
            // chkReceiveHex
            // 
            this.chkReceiveHex.Location = new System.Drawing.Point(127, 47);
            this.chkReceiveHex.Name = "chkReceiveHex";
            this.chkReceiveHex.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F);
            this.chkReceiveHex.Properties.Appearance.Options.UseFont = true;
            this.chkReceiveHex.Properties.Caption = "HEX";
            this.chkReceiveHex.Properties.CheckBoxOptions.Style = DevExpress.XtraEditors.Controls.CheckBoxStyle.Radio;
            this.chkReceiveHex.Properties.RadioGroupIndex = 1;
            this.chkReceiveHex.Size = new System.Drawing.Size(75, 23);
            this.chkReceiveHex.TabIndex = 1;
            this.chkReceiveHex.TabStop = false;
            // 
            // chkReceiveAscii
            // 
            this.chkReceiveAscii.EditValue = true;
            this.chkReceiveAscii.Location = new System.Drawing.Point(21, 47);
            this.chkReceiveAscii.Name = "chkReceiveAscii";
            this.chkReceiveAscii.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F);
            this.chkReceiveAscii.Properties.Appearance.Options.UseFont = true;
            this.chkReceiveAscii.Properties.Caption = "ASCII";
            this.chkReceiveAscii.Properties.CheckBoxOptions.Style = DevExpress.XtraEditors.Controls.CheckBoxStyle.Radio;
            this.chkReceiveAscii.Properties.RadioGroupIndex = 1;
            this.chkReceiveAscii.Size = new System.Drawing.Size(75, 23);
            this.chkReceiveAscii.TabIndex = 0;
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.btnOpenSerialPort);
            this.groupControl1.Controls.Add(this.comboBoxEditStopBits);
            this.groupControl1.Controls.Add(this.labelControl5);
            this.groupControl1.Controls.Add(this.comboBoxEditDataBits);
            this.groupControl1.Controls.Add(this.labelControl3);
            this.groupControl1.Controls.Add(this.comboBoxEditParity);
            this.groupControl1.Controls.Add(this.labelControl4);
            this.groupControl1.Controls.Add(this.comboBoxEditBaudRate);
            this.groupControl1.Controls.Add(this.labelControl2);
            this.groupControl1.Controls.Add(this.comboBoxEditPortName);
            this.groupControl1.Controls.Add(this.labelControl1);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupControl1.Location = new System.Drawing.Point(2, 2);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(224, 302);
            this.groupControl1.TabIndex = 0;
            this.groupControl1.Text = "串口设置";
            // 
            // btnOpenSerialPort
            // 
            this.btnOpenSerialPort.Appearance.Font = new System.Drawing.Font("Tahoma", 12F);
            this.btnOpenSerialPort.Appearance.Options.UseFont = true;
            this.btnOpenSerialPort.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.btnOpenSerialPort.ImageOptions.ImageToTextIndent = 6;
            this.btnOpenSerialPort.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.btnOpenSerialPort.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("simpleButton1.ImageOptions.SvgImage")));
            this.btnOpenSerialPort.ImageOptions.SvgImageSize = new System.Drawing.Size(20, 20);
            this.btnOpenSerialPort.Location = new System.Drawing.Point(17, 245);
            this.btnOpenSerialPort.Name = "btnOpenSerialPort";
            this.btnOpenSerialPort.Size = new System.Drawing.Size(192, 36);
            this.btnOpenSerialPort.TabIndex = 10;
            this.btnOpenSerialPort.Text = "打开连接";
            this.btnOpenSerialPort.Click += new System.EventHandler(this.btnOpenSerialPort_Click);
            // 
            // comboBoxEditStopBits
            // 
            this.comboBoxEditStopBits.Location = new System.Drawing.Point(74, 201);
            this.comboBoxEditStopBits.Name = "comboBoxEditStopBits";
            this.comboBoxEditStopBits.Properties.Appearance.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.comboBoxEditStopBits.Properties.Appearance.Options.UseFont = true;
            this.comboBoxEditStopBits.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.comboBoxEditStopBits.Size = new System.Drawing.Size(135, 22);
            this.comboBoxEditStopBits.TabIndex = 9;
            // 
            // labelControl5
            // 
            this.labelControl5.Appearance.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelControl5.Appearance.Options.UseFont = true;
            this.labelControl5.Location = new System.Drawing.Point(17, 203);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(48, 16);
            this.labelControl5.TabIndex = 8;
            this.labelControl5.Text = "停止位";
            // 
            // comboBoxEditDataBits
            // 
            this.comboBoxEditDataBits.Location = new System.Drawing.Point(74, 161);
            this.comboBoxEditDataBits.Name = "comboBoxEditDataBits";
            this.comboBoxEditDataBits.Properties.Appearance.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.comboBoxEditDataBits.Properties.Appearance.Options.UseFont = true;
            this.comboBoxEditDataBits.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.comboBoxEditDataBits.Size = new System.Drawing.Size(135, 22);
            this.comboBoxEditDataBits.TabIndex = 7;
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Location = new System.Drawing.Point(17, 163);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(48, 16);
            this.labelControl3.TabIndex = 6;
            this.labelControl3.Text = "数据位";
            // 
            // comboBoxEditParity
            // 
            this.comboBoxEditParity.Location = new System.Drawing.Point(74, 121);
            this.comboBoxEditParity.Name = "comboBoxEditParity";
            this.comboBoxEditParity.Properties.Appearance.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.comboBoxEditParity.Properties.Appearance.Options.UseFont = true;
            this.comboBoxEditParity.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.comboBoxEditParity.Size = new System.Drawing.Size(135, 22);
            this.comboBoxEditParity.TabIndex = 5;
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelControl4.Appearance.Options.UseFont = true;
            this.labelControl4.Location = new System.Drawing.Point(17, 123);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(48, 16);
            this.labelControl4.TabIndex = 4;
            this.labelControl4.Text = "校验位";
            // 
            // comboBoxEditBaudRate
            // 
            this.comboBoxEditBaudRate.Location = new System.Drawing.Point(74, 81);
            this.comboBoxEditBaudRate.Name = "comboBoxEditBaudRate";
            this.comboBoxEditBaudRate.Properties.Appearance.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.comboBoxEditBaudRate.Properties.Appearance.Options.UseFont = true;
            this.comboBoxEditBaudRate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.comboBoxEditBaudRate.Size = new System.Drawing.Size(135, 22);
            this.comboBoxEditBaudRate.TabIndex = 3;
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(17, 83);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(48, 16);
            this.labelControl2.TabIndex = 2;
            this.labelControl2.Text = "波特率";
            // 
            // comboBoxEditPortName
            // 
            this.comboBoxEditPortName.Location = new System.Drawing.Point(74, 41);
            this.comboBoxEditPortName.Name = "comboBoxEditPortName";
            this.comboBoxEditPortName.Properties.Appearance.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.comboBoxEditPortName.Properties.Appearance.Options.UseFont = true;
            this.comboBoxEditPortName.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.comboBoxEditPortName.Size = new System.Drawing.Size(135, 22);
            this.comboBoxEditPortName.TabIndex = 1;
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(17, 43);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(48, 16);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "串口号";
            // 
            // panelControl2
            // 
            this.panelControl2.Controls.Add(this.btnSend);
            this.panelControl2.Controls.Add(this.txtInputData);
            this.panelControl2.Controls.Add(this.groupControl4);
            this.panelControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl2.Location = new System.Drawing.Point(228, 0);
            this.panelControl2.Name = "panelControl2";
            this.panelControl2.Size = new System.Drawing.Size(960, 726);
            this.panelControl2.TabIndex = 1;
            // 
            // btnSend
            // 
            this.btnSend.Location = new System.Drawing.Point(848, 686);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(75, 23);
            this.btnSend.TabIndex = 5;
            this.btnSend.Text = "发送";
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // txtInputData
            // 
            this.txtInputData.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtInputData.EditValue = "请输入需要发送的内容";
            this.txtInputData.Location = new System.Drawing.Point(2, 569);
            this.txtInputData.Margin = new System.Windows.Forms.Padding(0);
            this.txtInputData.Name = "txtInputData";
            this.txtInputData.Properties.Appearance.ForeColor = System.Drawing.Color.Gray;
            this.txtInputData.Properties.Appearance.Options.UseForeColor = true;
            this.txtInputData.Size = new System.Drawing.Size(956, 155);
            this.txtInputData.TabIndex = 4;
            // 
            // groupControl4
            // 
            this.groupControl4.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.groupControl4.Controls.Add(this.memoEditShowLog);
            this.groupControl4.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupControl4.Location = new System.Drawing.Point(2, 2);
            this.groupControl4.Name = "groupControl4";
            this.groupControl4.Size = new System.Drawing.Size(956, 567);
            this.groupControl4.TabIndex = 3;
            this.groupControl4.Text = "数据日志";
            // 
            // memoEditShowLog
            // 
            this.memoEditShowLog.Dock = System.Windows.Forms.DockStyle.Fill;
            this.memoEditShowLog.Location = new System.Drawing.Point(2, 23);
            this.memoEditShowLog.Name = "memoEditShowLog";
            this.memoEditShowLog.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.memoEditShowLog.Properties.Appearance.Options.UseFont = true;
            this.memoEditShowLog.Size = new System.Drawing.Size(952, 542);
            this.memoEditShowLog.TabIndex = 0;
            // 
            // serialPort
            // 
            this.serialPort.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.serialPort_DataReceived);
            // 
            // SerialPortAssistant
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1188, 726);
            this.Controls.Add(this.panelControl2);
            this.Controls.Add(this.panelControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.MaximizeBox = false;
            this.Name = "SerialPortAssistant";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "串口通信助手";
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl3)).EndInit();
            this.groupControl3.ResumeLayout(false);
            this.groupControl3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtSendLoopMsec.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkSendLoop.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkSendRandom.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkSendHex.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkSendAscii.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chkReceiveScrolling.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkReceiveSaveFile.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkReceiveLog.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkReceiveHex.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkReceiveAscii.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.comboBoxEditStopBits.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.comboBoxEditDataBits.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.comboBoxEditParity.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.comboBoxEditBaudRate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.comboBoxEditPortName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            this.panelControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.txtInputData.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl4)).EndInit();
            this.groupControl4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.memoEditShowLog.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.PanelControl panelControl2;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private DevExpress.XtraEditors.GroupControl groupControl3;
        private DevExpress.XtraEditors.GroupControl groupControl4;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.MemoEdit memoEditShowLog;
        private DevExpress.XtraEditors.ComboBoxEdit comboBoxEditPortName;
        private DevExpress.XtraEditors.ComboBoxEdit comboBoxEditDataBits;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.ComboBoxEdit comboBoxEditParity;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.ComboBoxEdit comboBoxEditBaudRate;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.ComboBoxEdit comboBoxEditStopBits;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.SimpleButton btnOpenSerialPort;
        private DevExpress.XtraEditors.CheckEdit chkReceiveAscii;
        private DevExpress.XtraEditors.CheckEdit chkReceiveHex;
        private DevExpress.XtraEditors.CheckEdit chkReceiveScrolling;
        private DevExpress.XtraEditors.CheckEdit chkReceiveSaveFile;
        private DevExpress.XtraEditors.CheckEdit chkReceiveLog;
        private DevExpress.XtraEditors.CheckEdit chkSendHex;
        private DevExpress.XtraEditors.CheckEdit chkSendAscii;
        private DevExpress.XtraEditors.CheckEdit chkSendRandom;
        private DevExpress.XtraEditors.CheckEdit chkSendLoop;
        private DevExpress.XtraEditors.SimpleButton btnClearLog;
        private DevExpress.XtraEditors.MemoEdit txtInputData;
        private DevExpress.XtraEditors.SimpleButton btnSend;
        private DevExpress.XtraEditors.TextEdit txtSendLoopMsec;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private System.IO.Ports.SerialPort serialPort;
    }
}

