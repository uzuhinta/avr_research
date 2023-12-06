namespace ControlLed
{
    partial class Form1
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
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.grSetting = new System.Windows.Forms.GroupBox();
            this.btDisconnet = new System.Windows.Forms.Button();
            this.btConnect = new System.Windows.Forms.Button();
            this.cbStopBits = new System.Windows.Forms.ComboBox();
            this.cbParity = new System.Windows.Forms.ComboBox();
            this.cbDataSize = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cbPortBaud = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cbPortName = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.grStatus = new System.Windows.Forms.GroupBox();
            this.gbLed7 = new System.Windows.Forms.GroupBox();
            this.btLed7Off = new System.Windows.Forms.Button();
            this.btLed7On = new System.Windows.Forms.Button();
            this.gbLed4 = new System.Windows.Forms.GroupBox();
            this.btLed4Off = new System.Windows.Forms.Button();
            this.btLed4On = new System.Windows.Forms.Button();
            this.gbLed6 = new System.Windows.Forms.GroupBox();
            this.btLed6Off = new System.Windows.Forms.Button();
            this.btLed6On = new System.Windows.Forms.Button();
            this.gbLed3 = new System.Windows.Forms.GroupBox();
            this.btLed3Off = new System.Windows.Forms.Button();
            this.btLed3On = new System.Windows.Forms.Button();
            this.gbLed5 = new System.Windows.Forms.GroupBox();
            this.btLed5Off = new System.Windows.Forms.Button();
            this.btLed5On = new System.Windows.Forms.Button();
            this.gbLed2 = new System.Windows.Forms.GroupBox();
            this.btLed2Off = new System.Windows.Forms.Button();
            this.btLed2On = new System.Windows.Forms.Button();
            this.gbLed1 = new System.Windows.Forms.GroupBox();
            this.btLed1Off = new System.Windows.Forms.Button();
            this.btLed1On = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.tbMessage = new System.Windows.Forms.TextBox();
            this.grSetting.SuspendLayout();
            this.grStatus.SuspendLayout();
            this.gbLed7.SuspendLayout();
            this.gbLed4.SuspendLayout();
            this.gbLed6.SuspendLayout();
            this.gbLed3.SuspendLayout();
            this.gbLed5.SuspendLayout();
            this.gbLed2.SuspendLayout();
            this.gbLed1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // serialPort1
            // 
            this.serialPort1.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.serialPort1_DataReceived);
            // 
            // grSetting
            // 
            this.grSetting.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.grSetting.Controls.Add(this.btDisconnet);
            this.grSetting.Controls.Add(this.btConnect);
            this.grSetting.Controls.Add(this.cbStopBits);
            this.grSetting.Controls.Add(this.cbParity);
            this.grSetting.Controls.Add(this.cbDataSize);
            this.grSetting.Controls.Add(this.label5);
            this.grSetting.Controls.Add(this.cbPortBaud);
            this.grSetting.Controls.Add(this.label4);
            this.grSetting.Controls.Add(this.label3);
            this.grSetting.Controls.Add(this.cbPortName);
            this.grSetting.Controls.Add(this.label2);
            this.grSetting.Controls.Add(this.label1);
            this.grSetting.Location = new System.Drawing.Point(16, 17);
            this.grSetting.Name = "grSetting";
            this.grSetting.Size = new System.Drawing.Size(442, 407);
            this.grSetting.TabIndex = 0;
            this.grSetting.TabStop = false;
            this.grSetting.Text = "Setting COM";
            // 
            // btDisconnet
            // 
            this.btDisconnet.Location = new System.Drawing.Point(138, 352);
            this.btDisconnet.Name = "btDisconnet";
            this.btDisconnet.Size = new System.Drawing.Size(276, 49);
            this.btDisconnet.TabIndex = 3;
            this.btDisconnet.Text = "Disconnet";
            this.btDisconnet.UseVisualStyleBackColor = true;
            this.btDisconnet.Click += new System.EventHandler(this.btDisconnet_Click);
            // 
            // btConnect
            // 
            this.btConnect.Location = new System.Drawing.Point(138, 297);
            this.btConnect.Name = "btConnect";
            this.btConnect.Size = new System.Drawing.Size(276, 49);
            this.btConnect.TabIndex = 3;
            this.btConnect.Text = "Connect";
            this.btConnect.UseVisualStyleBackColor = true;
            this.btConnect.Click += new System.EventHandler(this.btConnect_Click);
            // 
            // cbStopBits
            // 
            this.cbStopBits.FormattingEnabled = true;
            this.cbStopBits.Items.AddRange(new object[] {
            "1",
            "2"});
            this.cbStopBits.Location = new System.Drawing.Point(138, 233);
            this.cbStopBits.Name = "cbStopBits";
            this.cbStopBits.Size = new System.Drawing.Size(276, 33);
            this.cbStopBits.TabIndex = 4;
            // 
            // cbParity
            // 
            this.cbParity.FormattingEnabled = true;
            this.cbParity.Items.AddRange(new object[] {
            "none",
            "even",
            "odd"});
            this.cbParity.Location = new System.Drawing.Point(138, 194);
            this.cbParity.Name = "cbParity";
            this.cbParity.Size = new System.Drawing.Size(276, 33);
            this.cbParity.TabIndex = 3;
            // 
            // cbDataSize
            // 
            this.cbDataSize.FormattingEnabled = true;
            this.cbDataSize.Items.AddRange(new object[] {
            "7",
            "8"});
            this.cbDataSize.Location = new System.Drawing.Point(138, 139);
            this.cbDataSize.Name = "cbDataSize";
            this.cbDataSize.Size = new System.Drawing.Size(276, 33);
            this.cbDataSize.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 236);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(91, 25);
            this.label5.TabIndex = 0;
            this.label5.Text = "Stop bit:";
            // 
            // cbPortBaud
            // 
            this.cbPortBaud.FormattingEnabled = true;
            this.cbPortBaud.Items.AddRange(new object[] {
            "4800",
            "9600",
            "14400",
            "19200",
            "38400",
            "56000",
            "57600",
            "115200"});
            this.cbPortBaud.Location = new System.Drawing.Point(138, 87);
            this.cbPortBaud.Name = "cbPortBaud";
            this.cbPortBaud.Size = new System.Drawing.Size(276, 33);
            this.cbPortBaud.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 197);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 25);
            this.label4.TabIndex = 0;
            this.label4.Text = "Parity:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 142);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(108, 25);
            this.label3.TabIndex = 0;
            this.label3.Text = "Data size:";
            // 
            // cbPortName
            // 
            this.cbPortName.FormattingEnabled = true;
            this.cbPortName.Location = new System.Drawing.Point(138, 38);
            this.cbPortName.Name = "cbPortName";
            this.cbPortName.Size = new System.Drawing.Size(276, 33);
            this.cbPortName.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 25);
            this.label2.TabIndex = 0;
            this.label2.Text = "Baud:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name:";
            // 
            // grStatus
            // 
            this.grStatus.Controls.Add(this.gbLed7);
            this.grStatus.Controls.Add(this.gbLed4);
            this.grStatus.Controls.Add(this.gbLed6);
            this.grStatus.Controls.Add(this.gbLed3);
            this.grStatus.Controls.Add(this.gbLed5);
            this.grStatus.Controls.Add(this.gbLed2);
            this.grStatus.Controls.Add(this.gbLed1);
            this.grStatus.Location = new System.Drawing.Point(495, 17);
            this.grStatus.Name = "grStatus";
            this.grStatus.Size = new System.Drawing.Size(449, 596);
            this.grStatus.TabIndex = 1;
            this.grStatus.TabStop = false;
            this.grStatus.Text = "Status";
            // 
            // gbLed7
            // 
            this.gbLed7.Controls.Add(this.btLed7Off);
            this.gbLed7.Controls.Add(this.btLed7On);
            this.gbLed7.Location = new System.Drawing.Point(144, 444);
            this.gbLed7.Name = "gbLed7";
            this.gbLed7.Size = new System.Drawing.Size(170, 132);
            this.gbLed7.TabIndex = 0;
            this.gbLed7.TabStop = false;
            this.gbLed7.Text = "Led 7";
            // 
            // btLed7Off
            // 
            this.btLed7Off.Location = new System.Drawing.Point(14, 87);
            this.btLed7Off.Name = "btLed7Off";
            this.btLed7Off.Size = new System.Drawing.Size(144, 39);
            this.btLed7Off.TabIndex = 0;
            this.btLed7Off.Text = "OFF";
            this.btLed7Off.UseVisualStyleBackColor = true;
            this.btLed7Off.Click += new System.EventHandler(this.btLed7Off_Click);
            // 
            // btLed7On
            // 
            this.btLed7On.Location = new System.Drawing.Point(14, 35);
            this.btLed7On.Name = "btLed7On";
            this.btLed7On.Size = new System.Drawing.Size(144, 39);
            this.btLed7On.TabIndex = 0;
            this.btLed7On.Text = "ON";
            this.btLed7On.UseVisualStyleBackColor = true;
            this.btLed7On.Click += new System.EventHandler(this.btLed7On_Click);
            // 
            // gbLed4
            // 
            this.gbLed4.Controls.Add(this.btLed4Off);
            this.gbLed4.Controls.Add(this.btLed4On);
            this.gbLed4.Location = new System.Drawing.Point(259, 35);
            this.gbLed4.Name = "gbLed4";
            this.gbLed4.Size = new System.Drawing.Size(170, 132);
            this.gbLed4.TabIndex = 0;
            this.gbLed4.TabStop = false;
            this.gbLed4.Text = "Led 4";
            // 
            // btLed4Off
            // 
            this.btLed4Off.Location = new System.Drawing.Point(14, 87);
            this.btLed4Off.Name = "btLed4Off";
            this.btLed4Off.Size = new System.Drawing.Size(144, 39);
            this.btLed4Off.TabIndex = 0;
            this.btLed4Off.Text = "OFF";
            this.btLed4Off.UseVisualStyleBackColor = true;
            this.btLed4Off.Click += new System.EventHandler(this.btLed4Off_Click);
            // 
            // btLed4On
            // 
            this.btLed4On.Location = new System.Drawing.Point(14, 35);
            this.btLed4On.Name = "btLed4On";
            this.btLed4On.Size = new System.Drawing.Size(144, 39);
            this.btLed4On.TabIndex = 0;
            this.btLed4On.Text = "ON";
            this.btLed4On.UseVisualStyleBackColor = true;
            this.btLed4On.Click += new System.EventHandler(this.btLed4On_Click);
            // 
            // gbLed6
            // 
            this.gbLed6.Controls.Add(this.btLed6Off);
            this.gbLed6.Controls.Add(this.btLed6On);
            this.gbLed6.Location = new System.Drawing.Point(259, 306);
            this.gbLed6.Name = "gbLed6";
            this.gbLed6.Size = new System.Drawing.Size(170, 132);
            this.gbLed6.TabIndex = 0;
            this.gbLed6.TabStop = false;
            this.gbLed6.Text = "Led 6";
            // 
            // btLed6Off
            // 
            this.btLed6Off.Location = new System.Drawing.Point(14, 87);
            this.btLed6Off.Name = "btLed6Off";
            this.btLed6Off.Size = new System.Drawing.Size(144, 39);
            this.btLed6Off.TabIndex = 0;
            this.btLed6Off.Text = "OFF";
            this.btLed6Off.UseVisualStyleBackColor = true;
            this.btLed6Off.Click += new System.EventHandler(this.btLed6Off_Click);
            // 
            // btLed6On
            // 
            this.btLed6On.Location = new System.Drawing.Point(14, 35);
            this.btLed6On.Name = "btLed6On";
            this.btLed6On.Size = new System.Drawing.Size(144, 39);
            this.btLed6On.TabIndex = 0;
            this.btLed6On.Text = "ON";
            this.btLed6On.UseVisualStyleBackColor = true;
            this.btLed6On.Click += new System.EventHandler(this.btLed6On_Click);
            // 
            // gbLed3
            // 
            this.gbLed3.Controls.Add(this.btLed3Off);
            this.gbLed3.Controls.Add(this.btLed3On);
            this.gbLed3.Location = new System.Drawing.Point(20, 306);
            this.gbLed3.Name = "gbLed3";
            this.gbLed3.Size = new System.Drawing.Size(170, 132);
            this.gbLed3.TabIndex = 0;
            this.gbLed3.TabStop = false;
            this.gbLed3.Text = "Led 3";
            // 
            // btLed3Off
            // 
            this.btLed3Off.Location = new System.Drawing.Point(14, 87);
            this.btLed3Off.Name = "btLed3Off";
            this.btLed3Off.Size = new System.Drawing.Size(144, 39);
            this.btLed3Off.TabIndex = 0;
            this.btLed3Off.Text = "OFF";
            this.btLed3Off.UseVisualStyleBackColor = true;
            this.btLed3Off.Click += new System.EventHandler(this.btLed3Off_Click);
            // 
            // btLed3On
            // 
            this.btLed3On.Location = new System.Drawing.Point(14, 35);
            this.btLed3On.Name = "btLed3On";
            this.btLed3On.Size = new System.Drawing.Size(144, 39);
            this.btLed3On.TabIndex = 0;
            this.btLed3On.Text = "ON";
            this.btLed3On.UseVisualStyleBackColor = true;
            this.btLed3On.Click += new System.EventHandler(this.btLed3On_Click);
            // 
            // gbLed5
            // 
            this.gbLed5.Controls.Add(this.btLed5Off);
            this.gbLed5.Controls.Add(this.btLed5On);
            this.gbLed5.Location = new System.Drawing.Point(259, 168);
            this.gbLed5.Name = "gbLed5";
            this.gbLed5.Size = new System.Drawing.Size(170, 132);
            this.gbLed5.TabIndex = 0;
            this.gbLed5.TabStop = false;
            this.gbLed5.Text = "Led 5";
            // 
            // btLed5Off
            // 
            this.btLed5Off.Location = new System.Drawing.Point(14, 87);
            this.btLed5Off.Name = "btLed5Off";
            this.btLed5Off.Size = new System.Drawing.Size(144, 39);
            this.btLed5Off.TabIndex = 0;
            this.btLed5Off.Text = "OFF";
            this.btLed5Off.UseVisualStyleBackColor = true;
            this.btLed5Off.Click += new System.EventHandler(this.btLed5Off_Click);
            // 
            // btLed5On
            // 
            this.btLed5On.Location = new System.Drawing.Point(14, 35);
            this.btLed5On.Name = "btLed5On";
            this.btLed5On.Size = new System.Drawing.Size(144, 39);
            this.btLed5On.TabIndex = 0;
            this.btLed5On.Text = "ON";
            this.btLed5On.UseVisualStyleBackColor = true;
            this.btLed5On.Click += new System.EventHandler(this.btLed5On_Click);
            // 
            // gbLed2
            // 
            this.gbLed2.Controls.Add(this.btLed2Off);
            this.gbLed2.Controls.Add(this.btLed2On);
            this.gbLed2.Location = new System.Drawing.Point(20, 168);
            this.gbLed2.Name = "gbLed2";
            this.gbLed2.Size = new System.Drawing.Size(170, 132);
            this.gbLed2.TabIndex = 0;
            this.gbLed2.TabStop = false;
            this.gbLed2.Text = "Led 2";
            // 
            // btLed2Off
            // 
            this.btLed2Off.Location = new System.Drawing.Point(14, 87);
            this.btLed2Off.Name = "btLed2Off";
            this.btLed2Off.Size = new System.Drawing.Size(144, 39);
            this.btLed2Off.TabIndex = 0;
            this.btLed2Off.Text = "OFF";
            this.btLed2Off.UseVisualStyleBackColor = true;
            this.btLed2Off.Click += new System.EventHandler(this.btLed2Off_Click);
            // 
            // btLed2On
            // 
            this.btLed2On.Location = new System.Drawing.Point(14, 35);
            this.btLed2On.Name = "btLed2On";
            this.btLed2On.Size = new System.Drawing.Size(144, 39);
            this.btLed2On.TabIndex = 0;
            this.btLed2On.Text = "ON";
            this.btLed2On.UseVisualStyleBackColor = true;
            this.btLed2On.Click += new System.EventHandler(this.btLed2On_Click);
            // 
            // gbLed1
            // 
            this.gbLed1.Controls.Add(this.btLed1Off);
            this.gbLed1.Controls.Add(this.btLed1On);
            this.gbLed1.Location = new System.Drawing.Point(20, 30);
            this.gbLed1.Name = "gbLed1";
            this.gbLed1.Size = new System.Drawing.Size(170, 132);
            this.gbLed1.TabIndex = 0;
            this.gbLed1.TabStop = false;
            this.gbLed1.Text = "Led 1";
            // 
            // btLed1Off
            // 
            this.btLed1Off.Location = new System.Drawing.Point(14, 87);
            this.btLed1Off.Name = "btLed1Off";
            this.btLed1Off.Size = new System.Drawing.Size(144, 39);
            this.btLed1Off.TabIndex = 0;
            this.btLed1Off.Text = "OFF";
            this.btLed1Off.UseVisualStyleBackColor = true;
            this.btLed1Off.Click += new System.EventHandler(this.btLed1Off_Click);
            // 
            // btLed1On
            // 
            this.btLed1On.Location = new System.Drawing.Point(14, 35);
            this.btLed1On.Name = "btLed1On";
            this.btLed1On.Size = new System.Drawing.Size(144, 39);
            this.btLed1On.TabIndex = 0;
            this.btLed1On.Text = "ON";
            this.btLed1On.UseVisualStyleBackColor = true;
            this.btLed1On.Click += new System.EventHandler(this.btLed1On_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.tbMessage);
            this.groupBox2.Location = new System.Drawing.Point(16, 430);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(442, 183);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Message";
            // 
            // tbMessage
            // 
            this.tbMessage.Location = new System.Drawing.Point(7, 30);
            this.tbMessage.Multiline = true;
            this.tbMessage.Name = "tbMessage";
            this.tbMessage.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.tbMessage.Size = new System.Drawing.Size(429, 147);
            this.tbMessage.TabIndex = 0;
            this.tbMessage.TextChanged += new System.EventHandler(this.tbMessage_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(956, 645);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.grStatus);
            this.Controls.Add(this.grSetting);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Control led";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Leave += new System.EventHandler(this.Form1_Leave);
            this.grSetting.ResumeLayout(false);
            this.grSetting.PerformLayout();
            this.grStatus.ResumeLayout(false);
            this.gbLed7.ResumeLayout(false);
            this.gbLed4.ResumeLayout(false);
            this.gbLed6.ResumeLayout(false);
            this.gbLed3.ResumeLayout(false);
            this.gbLed5.ResumeLayout(false);
            this.gbLed2.ResumeLayout(false);
            this.gbLed1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.GroupBox grSetting;
        private System.Windows.Forms.Button btDisconnet;
        private System.Windows.Forms.Button btConnect;
        private System.Windows.Forms.ComboBox cbParity;
        private System.Windows.Forms.ComboBox cbDataSize;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbPortName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox grStatus;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox tbMessage;
        private System.Windows.Forms.ComboBox cbStopBits;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox gbLed1;
        private System.Windows.Forms.Button btLed1Off;
        private System.Windows.Forms.Button btLed1On;
        protected System.Windows.Forms.ComboBox cbPortBaud;
        private System.Windows.Forms.GroupBox gbLed7;
        private System.Windows.Forms.Button btLed7Off;
        private System.Windows.Forms.Button btLed7On;
        private System.Windows.Forms.GroupBox gbLed4;
        private System.Windows.Forms.Button btLed4Off;
        private System.Windows.Forms.Button btLed4On;
        private System.Windows.Forms.GroupBox gbLed6;
        private System.Windows.Forms.Button btLed6Off;
        private System.Windows.Forms.Button btLed6On;
        private System.Windows.Forms.GroupBox gbLed3;
        private System.Windows.Forms.Button btLed3Off;
        private System.Windows.Forms.Button btLed3On;
        private System.Windows.Forms.GroupBox gbLed5;
        private System.Windows.Forms.Button btLed5Off;
        private System.Windows.Forms.Button btLed5On;
        private System.Windows.Forms.GroupBox gbLed2;
        private System.Windows.Forms.Button btLed2Off;
        private System.Windows.Forms.Button btLed2On;
    }
}

