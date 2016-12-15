using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CottonTestCore;
using System.IO;
using System.Threading;
using System.Drawing.Drawing2D;

namespace CottonTestWindow
{
    public partial class CottonTestWindow : Form
    {
        InterfaceCore core = new InterfaceCore();
        bool recording = false;
        List<double>[] output = new List<double>[3];
        public CottonTestWindow()
        {
            InitializeComponent();
            new ConsoleHelper(this.TextConsole);
            numericUpDown1.Maximum = InterfaceCore.PHOTODIODE.AMP3_RL_STEP_MAX;
            numericUpDown1.Minimum = 0;
            numericUpDown2.Maximum = InterfaceCore.PHOTODIODE.AMP3_RL_STEP_MAX;
            numericUpDown2.Minimum = 0;
            progressBar1.Maximum = (int)InterfaceCore.PHOTODIODE.AD_MAX;
            progressBar2.Maximum = (int)InterfaceCore.PHOTODIODE.AD_MAX;
            for (int i = 0; i < output.Length; i++)
            {
                output[i] = new List<double>();
            }
        }

        private void ButtonConnect_Click(object sender, EventArgs e)
        {
            try
            {
                core.connect(TextIP.Text,int.Parse(TextPort.Text));
                if (core.connected)
                {
                    ButtonStartStop.Enabled = true;
                    buttonReset.Enabled = true;
                }
                else
                {
                    Console.WriteLine("连接失败");
                }
            }
            catch (Exception exc)
            {
                Console.WriteLine(exc.Message);
            }
        }

        private void ButtonStartStop_Click(object sender, EventArgs e)
        {
            try
            {
                if (ButtonStartStop.Text == "开始")
                {
                    TimerData.Enabled = true;
                    TimerTemperature.Enabled = true;
                    ButtonStartStop.Text = "停止";
                }
                else
                {
                    TimerData.Enabled = false;
                    TimerTemperature.Enabled = false;
                    ButtonStartStop.Text = "开始";
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        private void ButtonRead1_Click(object sender, EventArgs e)
        {
            try
            {
                //TextMulti1.Text = core.GetSetRisistor(0).ToString();
                numericUpDown1.Value = core.GetSetRisistor(0);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        private void ButtonWrite1_Click(object sender, EventArgs e)
        {
            try
            {
                //int x = int.Parse(TextMulti1.Text);
                int x = (int)numericUpDown1.Value;
                if (x > InterfaceCore.PHOTODIODE.AMP3_RL_STEP_MAX || x < 0)
                    throw new Exception("调节超过了16级level");
                core.GetSetRisistor(0, true, x);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        private void ButtonRead2_Click(object sender, EventArgs e)
        {
            try
            {
                //TextMulti2.Text = core.GetSetRisistor(1).ToString();
                numericUpDown2.Value = core.GetSetRisistor(1);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        private void ButtonWrite2_Click(object sender, EventArgs e)
        {
            try
            {
                //int x = int.Parse(TextMulti2.Text);
                int x = (int)numericUpDown2.Value;
                if (x > InterfaceCore.PHOTODIODE.AMP3_RL_STEP_MAX || x < 0)
                    throw new Exception("调节超过了16级level");
                core.GetSetRisistor(1, true, x);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        private void TimerData_Tick(object sender, EventArgs e)
        {
            try
            {
                var val = core.GetData(false);
                TextOut1.Text = Math.Round(val.Key, 2).ToString();
                TextOut2.Text = Math.Round(val.Value, 2).ToString();
                TextOutdif.Text = Math.Round(val.Key - val.Value, 2).ToString();
                progressBar1.Value = (int)Math.Round(val.Key);
                progressBar2.Value = (int)Math.Round(val.Value);
                if (recording)
                {
                    output[0].Add(Math.Round(val.Key, 2));
                    output[1].Add(Math.Round(val.Value, 2));
                    output[2].Add(Math.Round(val.Key - val.Value, 2));
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        private void TimerTemperature_Tick(object sender, EventArgs e)
        {
            try
            {
                double val = core.GetTemperature(0);
                TextTemp1.Text = Math.Round(val, 2).ToString();
                val = core.GetTemperature(1);
                TextTemp2.Text = Math.Round(val, 2).ToString();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        private void buttonReset_Click(object sender, EventArgs e)
        {
            try
            {
                core.GetSetPeriod(true);
                core.GetSetWidth(true);
                ButtonRead1_Click(this, new EventArgs());
                ButtonRead2_Click(this, new EventArgs());
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            core.print_received = checkBox1.Checked;
        }

        private void buttonPrint_Click(object sender, EventArgs e)
        {
            Bitmap bit = new Bitmap(this.Width, this.Height);//实例化一个和窗体一样大的bitmap
            Graphics g = Graphics.FromImage(bit);
            g.CompositingQuality = CompositingQuality.HighQuality;//质量设为最高
            g.CopyFromScreen(this.Left, this.Top, 0, 0, new Size(this.Width, this.Height));//保存整个窗体为图片
            //只保存某个控件（这里是panel游戏区）
            //g.CopyFromScreen(panel游戏区 .PointToScreen(Point.Empty), Point.Empty, panel游戏区.Size);
            string str_dir = System.Environment.CurrentDirectory + "/screen_shot";
            if (Directory.Exists(str_dir) == false)//如果不存在就创建file文件夹
            {
                Directory.CreateDirectory(str_dir);
            }


            bit.Save(str_dir+"/window_" +DateTime.Now.ToString("yy_MM_dd_hh_mm_ss")+".png");//默认保存格式为PNG，保存成jpg格式质量不是很好
        }

        private void button_avg_write_Click(object sender, EventArgs e)
        {
            try
            {
                textBoxAVG.Text = core.GetSetAvg(true ,uint.Parse(textBoxAVG.Text)).ToString();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        private void button_avg_read_Click(object sender, EventArgs e)
        {
            try
            {
                textBoxAVG.Text = core.GetSetAvg().ToString();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        private void button1_MouseDown(object sender, MouseEventArgs e)
        {
            try
            {
                for (int i = 0; i < output.Length; i++)
                {
                    output[i].Clear();
                }
                recording = true;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        private void button1_MouseUp(object sender, MouseEventArgs e)
        {
            try
            {
                for (int i = 0; i < output.Length; i++)
                {
                    var x = output[i].Sum() / output[i].Count;
                    textBoxInfo.AppendText(Math.Round(x).ToString() + ",");
                    output[i].Clear();
                }
                textBoxInfo.AppendText("\r\n");
                recording = false;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                string str_dir = System.Environment.CurrentDirectory + "/data";
                if (Directory.Exists(str_dir) == false)//如果不存在就创建file文件夹
                {
                    Directory.CreateDirectory(str_dir);
                }
                FileStream fs = new FileStream(str_dir + "/data_" + DateTime.Now.ToString("yy_MM_dd_hh_mm_ss") + ".csv", FileMode.Create);
                StreamWriter sw = new StreamWriter(fs);
                //开始写入
                sw.Write(textBoxInfo.Text);
                //清空缓冲区
                sw.Flush();
                //关闭流
                sw.Close();
                fs.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }

    public class ConsoleHelper : TextWriter
    {

        private System.Windows.Forms.TextBox _textBox { set; get; }//如果是wpf的也可以换做wpf的输入框

        public ConsoleHelper(System.Windows.Forms.TextBox textBox)
        {
            this._textBox = textBox;
            Console.SetOut(this);
        }

        public override void Write(string value)
        {
            if (_textBox.IsHandleCreated)
                _textBox.BeginInvoke(new ThreadStart(() => _textBox.AppendText(value + " ")));
        }

        public override void WriteLine(string value)
        {
            if (_textBox.IsHandleCreated)
                _textBox.BeginInvoke(new ThreadStart(() => _textBox.AppendText(value + "\r\n")));
        }

        public override Encoding Encoding//这里要注意,重写wirte必须也要重写编码类型
        {
            get { return Encoding.UTF8; }
        }


    }
}
