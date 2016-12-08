namespace CottonTestWindow
{
    partial class CottonTestWindow
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
            this.label1 = new System.Windows.Forms.Label();
            this.TextConsole = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Text12AD1 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.TextRevserved1 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.TextPWM1 = new System.Windows.Forms.TextBox();
            this.ButtonWrite1 = new System.Windows.Forms.Button();
            this.ButtonRead1 = new System.Windows.Forms.Button();
            this.ButtonReserverd1 = new System.Windows.Forms.Button();
            this.ButtonReserverd2 = new System.Windows.Forms.Button();
            this.ButtonRead2 = new System.Windows.Forms.Button();
            this.ButtonWrite2 = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.TextRevserved2 = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.TextPWM2 = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.Text12AD2 = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.TextTemp1 = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.TextOut1 = new System.Windows.Forms.TextBox();
            this.TextOut2 = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.TextTemp2 = new System.Windows.Forms.TextBox();
            this.label20 = new System.Windows.Forms.Label();
            this.TextOutdif = new System.Windows.Forms.TextBox();
            this.label21 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.TextIP = new System.Windows.Forms.TextBox();
            this.label23 = new System.Windows.Forms.Label();
            this.TextPort = new System.Windows.Forms.TextBox();
            this.label24 = new System.Windows.Forms.Label();
            this.TextConnectReserverd = new System.Windows.Forms.TextBox();
            this.label25 = new System.Windows.Forms.Label();
            this.TextFre = new System.Windows.Forms.TextBox();
            this.ButtonConnect = new System.Windows.Forms.Button();
            this.ButtonStartStop = new System.Windows.Forms.Button();
            this.TimerData = new System.Windows.Forms.Timer(this.components);
            this.TimerTemperature = new System.Windows.Forms.Timer(this.components);
            this.buttonReset = new System.Windows.Forms.Button();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown2 = new System.Windows.Forms.NumericUpDown();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "控制台输出";
            // 
            // TextConsole
            // 
            this.TextConsole.Location = new System.Drawing.Point(12, 28);
            this.TextConsole.MaxLength = 2147483647;
            this.TextConsole.Multiline = true;
            this.TextConsole.Name = "TextConsole";
            this.TextConsole.ReadOnly = true;
            this.TextConsole.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.TextConsole.Size = new System.Drawing.Size(449, 292);
            this.TextConsole.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(467, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "参数控制";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(468, 76);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "可变运放电阻等级";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(666, 76);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 16);
            this.label4.TabIndex = 6;
            this.label4.Text = "12位AD时钟";
            // 
            // Text12AD1
            // 
            this.Text12AD1.Location = new System.Drawing.Point(743, 73);
            this.Text12AD1.Name = "Text12AD1";
            this.Text12AD1.ReadOnly = true;
            this.Text12AD1.Size = new System.Drawing.Size(130, 22);
            this.Text12AD1.TabIndex = 5;
            this.Text12AD1.Text = "不可控";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(468, 31);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 16);
            this.label5.TabIndex = 7;
            this.label5.Text = "传感器1";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(666, 104);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(68, 16);
            this.label6.TabIndex = 11;
            this.label6.Text = "保留控制位";
            // 
            // TextRevserved1
            // 
            this.TextRevserved1.Enabled = false;
            this.TextRevserved1.Location = new System.Drawing.Point(743, 101);
            this.TextRevserved1.Name = "TextRevserved1";
            this.TextRevserved1.Size = new System.Drawing.Size(130, 22);
            this.TextRevserved1.TabIndex = 10;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(468, 104);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(53, 16);
            this.label7.TabIndex = 9;
            this.label7.Text = "冷却PWM";
            // 
            // TextPWM1
            // 
            this.TextPWM1.Location = new System.Drawing.Point(530, 101);
            this.TextPWM1.Name = "TextPWM1";
            this.TextPWM1.ReadOnly = true;
            this.TextPWM1.Size = new System.Drawing.Size(130, 22);
            this.TextPWM1.TabIndex = 8;
            this.TextPWM1.Text = "不可控";
            // 
            // ButtonWrite1
            // 
            this.ButtonWrite1.Location = new System.Drawing.Point(797, 129);
            this.ButtonWrite1.Name = "ButtonWrite1";
            this.ButtonWrite1.Size = new System.Drawing.Size(75, 23);
            this.ButtonWrite1.TabIndex = 12;
            this.ButtonWrite1.Text = "写入";
            this.ButtonWrite1.UseVisualStyleBackColor = true;
            this.ButtonWrite1.Click += new System.EventHandler(this.ButtonWrite1_Click);
            // 
            // ButtonRead1
            // 
            this.ButtonRead1.Location = new System.Drawing.Point(470, 129);
            this.ButtonRead1.Name = "ButtonRead1";
            this.ButtonRead1.Size = new System.Drawing.Size(75, 23);
            this.ButtonRead1.TabIndex = 13;
            this.ButtonRead1.Text = "读取";
            this.ButtonRead1.UseVisualStyleBackColor = true;
            this.ButtonRead1.Click += new System.EventHandler(this.ButtonRead1_Click);
            // 
            // ButtonReserverd1
            // 
            this.ButtonReserverd1.Enabled = false;
            this.ButtonReserverd1.Location = new System.Drawing.Point(642, 129);
            this.ButtonReserverd1.Name = "ButtonReserverd1";
            this.ButtonReserverd1.Size = new System.Drawing.Size(75, 23);
            this.ButtonReserverd1.TabIndex = 14;
            this.ButtonReserverd1.Text = "保留按钮";
            this.ButtonReserverd1.UseVisualStyleBackColor = true;
            // 
            // ButtonReserverd2
            // 
            this.ButtonReserverd2.Enabled = false;
            this.ButtonReserverd2.Location = new System.Drawing.Point(643, 265);
            this.ButtonReserverd2.Name = "ButtonReserverd2";
            this.ButtonReserverd2.Size = new System.Drawing.Size(75, 23);
            this.ButtonReserverd2.TabIndex = 26;
            this.ButtonReserverd2.Text = "保留按钮";
            this.ButtonReserverd2.UseVisualStyleBackColor = true;
            // 
            // ButtonRead2
            // 
            this.ButtonRead2.Location = new System.Drawing.Point(471, 265);
            this.ButtonRead2.Name = "ButtonRead2";
            this.ButtonRead2.Size = new System.Drawing.Size(75, 23);
            this.ButtonRead2.TabIndex = 25;
            this.ButtonRead2.Text = "读取";
            this.ButtonRead2.UseVisualStyleBackColor = true;
            this.ButtonRead2.Click += new System.EventHandler(this.ButtonRead2_Click);
            // 
            // ButtonWrite2
            // 
            this.ButtonWrite2.Location = new System.Drawing.Point(798, 265);
            this.ButtonWrite2.Name = "ButtonWrite2";
            this.ButtonWrite2.Size = new System.Drawing.Size(75, 23);
            this.ButtonWrite2.TabIndex = 24;
            this.ButtonWrite2.Text = "写入";
            this.ButtonWrite2.UseVisualStyleBackColor = true;
            this.ButtonWrite2.Click += new System.EventHandler(this.ButtonWrite2_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(666, 240);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(68, 16);
            this.label8.TabIndex = 23;
            this.label8.Text = "保留控制位";
            // 
            // TextRevserved2
            // 
            this.TextRevserved2.Enabled = false;
            this.TextRevserved2.Location = new System.Drawing.Point(743, 237);
            this.TextRevserved2.Name = "TextRevserved2";
            this.TextRevserved2.Size = new System.Drawing.Size(130, 22);
            this.TextRevserved2.TabIndex = 22;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(468, 240);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(53, 16);
            this.label9.TabIndex = 21;
            this.label9.Text = "冷却PWM";
            // 
            // TextPWM2
            // 
            this.TextPWM2.Location = new System.Drawing.Point(530, 237);
            this.TextPWM2.Name = "TextPWM2";
            this.TextPWM2.ReadOnly = true;
            this.TextPWM2.Size = new System.Drawing.Size(130, 22);
            this.TextPWM2.TabIndex = 20;
            this.TextPWM2.Text = "不可控";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(468, 173);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(51, 16);
            this.label10.TabIndex = 19;
            this.label10.Text = "传感器2";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(666, 212);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(72, 16);
            this.label11.TabIndex = 18;
            this.label11.Text = "12位AD时钟";
            // 
            // Text12AD2
            // 
            this.Text12AD2.Location = new System.Drawing.Point(743, 209);
            this.Text12AD2.Name = "Text12AD2";
            this.Text12AD2.ReadOnly = true;
            this.Text12AD2.Size = new System.Drawing.Size(130, 22);
            this.Text12AD2.TabIndex = 17;
            this.Text12AD2.Text = "不可控";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(468, 212);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(104, 16);
            this.label12.TabIndex = 16;
            this.label12.Text = "可变运放电阻等级";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(12, 323);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(80, 16);
            this.label13.TabIndex = 27;
            this.label13.Text = "实时输出显示";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(12, 375);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(32, 16);
            this.label14.TabIndex = 29;
            this.label14.Text = "温度";
            // 
            // TextTemp1
            // 
            this.TextTemp1.Location = new System.Drawing.Point(74, 372);
            this.TextTemp1.Name = "TextTemp1";
            this.TextTemp1.ReadOnly = true;
            this.TextTemp1.Size = new System.Drawing.Size(130, 22);
            this.TextTemp1.TabIndex = 28;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(12, 349);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(51, 16);
            this.label15.TabIndex = 30;
            this.label15.Text = "传感器1";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(12, 401);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(32, 16);
            this.label16.TabIndex = 31;
            this.label16.Text = "输出";
            // 
            // TextOut1
            // 
            this.TextOut1.Location = new System.Drawing.Point(74, 398);
            this.TextOut1.Name = "TextOut1";
            this.TextOut1.ReadOnly = true;
            this.TextOut1.Size = new System.Drawing.Size(130, 22);
            this.TextOut1.TabIndex = 32;
            // 
            // TextOut2
            // 
            this.TextOut2.Location = new System.Drawing.Point(291, 398);
            this.TextOut2.Name = "TextOut2";
            this.TextOut2.ReadOnly = true;
            this.TextOut2.Size = new System.Drawing.Size(130, 22);
            this.TextOut2.TabIndex = 37;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(229, 401);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(32, 16);
            this.label17.TabIndex = 36;
            this.label17.Text = "输出";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(229, 349);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(51, 16);
            this.label18.TabIndex = 35;
            this.label18.Text = "传感器2";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(229, 375);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(32, 16);
            this.label19.TabIndex = 34;
            this.label19.Text = "温度";
            // 
            // TextTemp2
            // 
            this.TextTemp2.Location = new System.Drawing.Point(291, 372);
            this.TextTemp2.Name = "TextTemp2";
            this.TextTemp2.ReadOnly = true;
            this.TextTemp2.Size = new System.Drawing.Size(130, 22);
            this.TextTemp2.TabIndex = 33;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(89, 433);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(68, 16);
            this.label20.TabIndex = 38;
            this.label20.Text = "传感器求差";
            // 
            // TextOutdif
            // 
            this.TextOutdif.Location = new System.Drawing.Point(163, 430);
            this.TextOutdif.Name = "TextOutdif";
            this.TextOutdif.ReadOnly = true;
            this.TextOutdif.Size = new System.Drawing.Size(130, 22);
            this.TextOutdif.TabIndex = 39;
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(468, 323);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(56, 16);
            this.label21.TabIndex = 40;
            this.label21.Text = "连接控制";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(468, 349);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(22, 16);
            this.label22.TabIndex = 42;
            this.label22.Text = "IP";
            // 
            // TextIP
            // 
            this.TextIP.Location = new System.Drawing.Point(530, 346);
            this.TextIP.Name = "TextIP";
            this.TextIP.Size = new System.Drawing.Size(130, 22);
            this.TextIP.TabIndex = 41;
            this.TextIP.Text = "127.0.0.1";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(682, 349);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(36, 16);
            this.label23.TabIndex = 44;
            this.label23.Text = "Port";
            // 
            // TextPort
            // 
            this.TextPort.Location = new System.Drawing.Point(742, 346);
            this.TextPort.Name = "TextPort";
            this.TextPort.Size = new System.Drawing.Size(130, 22);
            this.TextPort.TabIndex = 43;
            this.TextPort.Text = "986";
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Location = new System.Drawing.Point(670, 378);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(68, 16);
            this.label24.TabIndex = 48;
            this.label24.Text = "保留控制位";
            // 
            // TextConnectReserverd
            // 
            this.TextConnectReserverd.Location = new System.Drawing.Point(742, 375);
            this.TextConnectReserverd.Name = "TextConnectReserverd";
            this.TextConnectReserverd.Size = new System.Drawing.Size(130, 22);
            this.TextConnectReserverd.TabIndex = 47;
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Location = new System.Drawing.Point(468, 378);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(32, 16);
            this.label25.TabIndex = 46;
            this.label25.Text = "频率";
            // 
            // TextFre
            // 
            this.TextFre.Location = new System.Drawing.Point(530, 375);
            this.TextFre.Name = "TextFre";
            this.TextFre.ReadOnly = true;
            this.TextFre.Size = new System.Drawing.Size(130, 22);
            this.TextFre.TabIndex = 45;
            // 
            // ButtonConnect
            // 
            this.ButtonConnect.Location = new System.Drawing.Point(471, 403);
            this.ButtonConnect.Name = "ButtonConnect";
            this.ButtonConnect.Size = new System.Drawing.Size(75, 23);
            this.ButtonConnect.TabIndex = 49;
            this.ButtonConnect.Text = "连接";
            this.ButtonConnect.UseVisualStyleBackColor = true;
            this.ButtonConnect.Click += new System.EventHandler(this.ButtonConnect_Click);
            // 
            // ButtonStartStop
            // 
            this.ButtonStartStop.Enabled = false;
            this.ButtonStartStop.Location = new System.Drawing.Point(798, 403);
            this.ButtonStartStop.Name = "ButtonStartStop";
            this.ButtonStartStop.Size = new System.Drawing.Size(75, 23);
            this.ButtonStartStop.TabIndex = 50;
            this.ButtonStartStop.Text = "开始";
            this.ButtonStartStop.UseVisualStyleBackColor = true;
            this.ButtonStartStop.Click += new System.EventHandler(this.ButtonStartStop_Click);
            // 
            // TimerData
            // 
            this.TimerData.Tick += new System.EventHandler(this.TimerData_Tick);
            // 
            // TimerTemperature
            // 
            this.TimerTemperature.Interval = 1000;
            this.TimerTemperature.Tick += new System.EventHandler(this.TimerTemperature_Tick);
            // 
            // buttonReset
            // 
            this.buttonReset.Enabled = false;
            this.buttonReset.Location = new System.Drawing.Point(643, 403);
            this.buttonReset.Name = "buttonReset";
            this.buttonReset.Size = new System.Drawing.Size(91, 23);
            this.buttonReset.TabIndex = 51;
            this.buttonReset.Text = "初始化帧率";
            this.buttonReset.UseVisualStyleBackColor = true;
            this.buttonReset.Click += new System.EventHandler(this.buttonReset_Click);
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(578, 74);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            15,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(82, 22);
            this.numericUpDown1.TabIndex = 52;
            this.numericUpDown1.Value = new decimal(new int[] {
            15,
            0,
            0,
            0});
            // 
            // numericUpDown2
            // 
            this.numericUpDown2.Location = new System.Drawing.Point(578, 210);
            this.numericUpDown2.Maximum = new decimal(new int[] {
            15,
            0,
            0,
            0});
            this.numericUpDown2.Name = "numericUpDown2";
            this.numericUpDown2.Size = new System.Drawing.Size(82, 22);
            this.numericUpDown2.TabIndex = 53;
            this.numericUpDown2.Value = new decimal(new int[] {
            15,
            0,
            0,
            0});
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Checked = true;
            this.checkBox1.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox1.Location = new System.Drawing.Point(350, 8);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(111, 20);
            this.checkBox1.TabIndex = 54;
            this.checkBox1.Text = "打印收到的数据";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // CottonTestWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 465);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.numericUpDown2);
            this.Controls.Add(this.numericUpDown1);
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
            this.Controls.Add(this.label21);
            this.Controls.Add(this.TextOutdif);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.TextOut2);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.TextTemp2);
            this.Controls.Add(this.TextOut1);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.TextTemp1);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.ButtonReserverd2);
            this.Controls.Add(this.ButtonRead2);
            this.Controls.Add(this.ButtonWrite2);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.TextRevserved2);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.TextPWM2);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.Text12AD2);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.ButtonReserverd1);
            this.Controls.Add(this.ButtonRead1);
            this.Controls.Add(this.ButtonWrite1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.TextRevserved1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.TextPWM1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Text12AD1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TextConsole);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft YaHei Mono", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "CottonTestWindow";
            this.Text = "CottonTest";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TextConsole;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox Text12AD1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox TextRevserved1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox TextPWM1;
        private System.Windows.Forms.Button ButtonWrite1;
        private System.Windows.Forms.Button ButtonRead1;
        private System.Windows.Forms.Button ButtonReserverd1;
        private System.Windows.Forms.Button ButtonReserverd2;
        private System.Windows.Forms.Button ButtonRead2;
        private System.Windows.Forms.Button ButtonWrite2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox TextRevserved2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox TextPWM2;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox Text12AD2;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox TextTemp1;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox TextOut1;
        private System.Windows.Forms.TextBox TextOut2;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.TextBox TextTemp2;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.TextBox TextOutdif;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.TextBox TextIP;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.TextBox TextPort;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.TextBox TextConnectReserverd;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.TextBox TextFre;
        private System.Windows.Forms.Button ButtonConnect;
        private System.Windows.Forms.Button ButtonStartStop;
        private System.Windows.Forms.Timer TimerData;
        private System.Windows.Forms.Timer TimerTemperature;
        private System.Windows.Forms.Button buttonReset;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.NumericUpDown numericUpDown2;
        private System.Windows.Forms.CheckBox checkBox1;
    }
}

