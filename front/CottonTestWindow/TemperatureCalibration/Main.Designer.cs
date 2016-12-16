namespace TemperatureCalibration
{
    partial class Main
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.buttonReset = new System.Windows.Forms.Button();
            this.ButtonStartStop = new System.Windows.Forms.Button();
            this.ButtonConnect = new System.Windows.Forms.Button();
            this.label24 = new System.Windows.Forms.Label();
            this.TextConnectReserverd = new System.Windows.Forms.TextBox();
            this.label25 = new System.Windows.Forms.Label();
            this.TextFre = new System.Windows.Forms.TextBox();
            this.label23 = new System.Windows.Forms.Label();
            this.TextPort = new System.Windows.Forms.TextBox();
            this.label22 = new System.Windows.Forms.Label();
            this.TextIP = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox53 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox54 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox52 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox51 = new System.Windows.Forms.TextBox();
            this.textBox61 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox62 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.textBox64 = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.textBox63 = new System.Windows.Forms.TextBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // buttonReset
            // 
            this.buttonReset.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonReset.Enabled = false;
            this.buttonReset.Location = new System.Drawing.Point(231, 342);
            this.buttonReset.Name = "buttonReset";
            this.buttonReset.Size = new System.Drawing.Size(74, 23);
            this.buttonReset.TabIndex = 62;
            this.buttonReset.Text = "初始化";
            this.buttonReset.UseVisualStyleBackColor = true;
            // 
            // ButtonStartStop
            // 
            this.ButtonStartStop.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ButtonStartStop.Enabled = false;
            this.ButtonStartStop.Location = new System.Drawing.Point(386, 342);
            this.ButtonStartStop.Name = "ButtonStartStop";
            this.ButtonStartStop.Size = new System.Drawing.Size(75, 23);
            this.ButtonStartStop.TabIndex = 61;
            this.ButtonStartStop.Text = "开始";
            this.ButtonStartStop.UseVisualStyleBackColor = true;
            this.ButtonStartStop.Click += new System.EventHandler(this.ButtonStartStop_Click);
            // 
            // ButtonConnect
            // 
            this.ButtonConnect.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ButtonConnect.Location = new System.Drawing.Point(59, 342);
            this.ButtonConnect.Name = "ButtonConnect";
            this.ButtonConnect.Size = new System.Drawing.Size(75, 23);
            this.ButtonConnect.TabIndex = 60;
            this.ButtonConnect.Text = "连接";
            this.ButtonConnect.UseVisualStyleBackColor = true;
            this.ButtonConnect.Click += new System.EventHandler(this.ButtonConnect_Click);
            // 
            // label24
            // 
            this.label24.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label24.AutoSize = true;
            this.label24.Location = new System.Drawing.Point(258, 317);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(68, 16);
            this.label24.TabIndex = 59;
            this.label24.Text = "保留控制位";
            // 
            // TextConnectReserverd
            // 
            this.TextConnectReserverd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.TextConnectReserverd.Location = new System.Drawing.Point(330, 314);
            this.TextConnectReserverd.Name = "TextConnectReserverd";
            this.TextConnectReserverd.Size = new System.Drawing.Size(130, 22);
            this.TextConnectReserverd.TabIndex = 58;
            // 
            // label25
            // 
            this.label25.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label25.AutoSize = true;
            this.label25.Location = new System.Drawing.Point(56, 317);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(32, 16);
            this.label25.TabIndex = 57;
            this.label25.Text = "频率";
            // 
            // TextFre
            // 
            this.TextFre.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.TextFre.Location = new System.Drawing.Point(118, 314);
            this.TextFre.Name = "TextFre";
            this.TextFre.ReadOnly = true;
            this.TextFre.Size = new System.Drawing.Size(130, 22);
            this.TextFre.TabIndex = 56;
            // 
            // label23
            // 
            this.label23.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(270, 288);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(36, 16);
            this.label23.TabIndex = 55;
            this.label23.Text = "Port";
            // 
            // TextPort
            // 
            this.TextPort.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.TextPort.Location = new System.Drawing.Point(330, 285);
            this.TextPort.Name = "TextPort";
            this.TextPort.Size = new System.Drawing.Size(130, 22);
            this.TextPort.TabIndex = 54;
            this.TextPort.Text = "986";
            // 
            // label22
            // 
            this.label22.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(56, 288);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(22, 16);
            this.label22.TabIndex = 53;
            this.label22.Text = "IP";
            // 
            // TextIP
            // 
            this.TextIP.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.TextIP.Location = new System.Drawing.Point(118, 285);
            this.TextIP.Name = "TextIP";
            this.TextIP.Size = new System.Drawing.Size(130, 22);
            this.TextIP.TabIndex = 52;
            this.TextIP.Text = "127.0.0.1";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(13, 13);
            this.textBox1.MaxLength = 2000000000;
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(292, 239);
            this.textBox1.TabIndex = 63;
            // 
            // textBox53
            // 
            this.textBox53.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox53.Location = new System.Drawing.Point(385, 87);
            this.textBox53.Name = "textBox53";
            this.textBox53.Size = new System.Drawing.Size(75, 22);
            this.textBox53.TabIndex = 64;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(311, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(15, 16);
            this.label1.TabIndex = 65;
            this.label1.Text = "1";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(311, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 16);
            this.label2.TabIndex = 66;
            this.label2.Text = "反算电压值";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(311, 118);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 16);
            this.label3.TabIndex = 67;
            this.label3.Text = "反算温度值";
            // 
            // textBox54
            // 
            this.textBox54.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox54.Location = new System.Drawing.Point(385, 115);
            this.textBox54.Name = "textBox54";
            this.textBox54.Size = new System.Drawing.Size(75, 22);
            this.textBox54.TabIndex = 68;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(311, 62);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 16);
            this.label4.TabIndex = 69;
            this.label4.Text = "收到的值";
            // 
            // textBox52
            // 
            this.textBox52.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox52.Location = new System.Drawing.Point(385, 59);
            this.textBox52.Name = "textBox52";
            this.textBox52.Size = new System.Drawing.Size(75, 22);
            this.textBox52.TabIndex = 70;
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(311, 35);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 16);
            this.label5.TabIndex = 71;
            this.label5.Text = "电阻大小";
            // 
            // textBox51
            // 
            this.textBox51.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox51.Location = new System.Drawing.Point(385, 32);
            this.textBox51.Name = "textBox51";
            this.textBox51.Size = new System.Drawing.Size(75, 22);
            this.textBox51.TabIndex = 72;
            this.textBox51.Text = "100";
            // 
            // textBox61
            // 
            this.textBox61.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox61.Location = new System.Drawing.Point(386, 160);
            this.textBox61.Name = "textBox61";
            this.textBox61.Size = new System.Drawing.Size(75, 22);
            this.textBox61.TabIndex = 81;
            this.textBox61.Text = "100";
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(312, 163);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 16);
            this.label6.TabIndex = 80;
            this.label6.Text = "电阻大小";
            // 
            // textBox62
            // 
            this.textBox62.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox62.Location = new System.Drawing.Point(386, 187);
            this.textBox62.Name = "textBox62";
            this.textBox62.Size = new System.Drawing.Size(75, 22);
            this.textBox62.TabIndex = 79;
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(312, 190);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(56, 16);
            this.label7.TabIndex = 78;
            this.label7.Text = "收到的值";
            // 
            // textBox64
            // 
            this.textBox64.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox64.Location = new System.Drawing.Point(386, 243);
            this.textBox64.Name = "textBox64";
            this.textBox64.Size = new System.Drawing.Size(75, 22);
            this.textBox64.TabIndex = 77;
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(312, 246);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(68, 16);
            this.label8.TabIndex = 76;
            this.label8.Text = "反算温度值";
            // 
            // label9
            // 
            this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(312, 218);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(68, 16);
            this.label9.TabIndex = 75;
            this.label9.Text = "反算电压值";
            // 
            // label10
            // 
            this.label10.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(312, 144);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(15, 16);
            this.label10.TabIndex = 74;
            this.label10.Text = "2";
            // 
            // textBox63
            // 
            this.textBox63.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox63.Location = new System.Drawing.Point(386, 215);
            this.textBox63.Name = "textBox63";
            this.textBox63.Size = new System.Drawing.Size(75, 22);
            this.textBox63.TabIndex = 73;
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(472, 372);
            this.Controls.Add(this.textBox61);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textBox62);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.textBox64);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.textBox63);
            this.Controls.Add(this.textBox51);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBox52);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBox54);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox53);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.buttonReset);
            this.Controls.Add(this.ButtonStartStop);
            this.Controls.Add(this.ButtonConnect);
            this.Controls.Add(this.label24);
            this.Controls.Add(this.TextConnectReserverd);
            this.Controls.Add(this.label25);
            this.Controls.Add(this.TextFre);
            this.Controls.Add(this.label23);
            this.Controls.Add(this.TextPort);
            this.Controls.Add(this.label22);
            this.Controls.Add(this.TextIP);
            this.Font = new System.Drawing.Font("Microsoft YaHei Mono", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Main";
            this.Text = "TemperatureCalibration";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonReset;
        private System.Windows.Forms.Button ButtonStartStop;
        private System.Windows.Forms.Button ButtonConnect;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.TextBox TextConnectReserverd;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.TextBox TextFre;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.TextBox TextPort;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.TextBox TextIP;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox53;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox54;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox52;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox51;
        private System.Windows.Forms.TextBox textBox61;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox62;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBox64;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox textBox63;
        private System.Windows.Forms.Timer timer1;
    }
}

