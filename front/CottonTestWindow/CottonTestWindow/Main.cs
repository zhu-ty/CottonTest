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

namespace CottonTestWindow
{
    public partial class CottonTestWindow : Form
    {
        InterfaceCore core = new InterfaceCore();
        public CottonTestWindow()
        {
            InitializeComponent();
            new ConsoleHelper(this.TextConsole);
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
                TextMulti1.Text = core.GetSetRisistor(0).ToString();
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
                int x = int.Parse(TextMulti1.Text);
                if (x > 15 || x < 0)
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
                TextMulti2.Text = core.GetSetRisistor(1).ToString();
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
                int x = int.Parse(TextMulti2.Text);
                if (x > 15 || x < 0)
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
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        private void TimerTemperature_Tick(object sender, EventArgs e)
        {
            double val = core.GetTemperature(0);
            TextTemp1.Text = Math.Round(val, 2).ToString();
            val = core.GetTemperature(1);
            TextTemp2.Text = Math.Round(val, 2).ToString();
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
