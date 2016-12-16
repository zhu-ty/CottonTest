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

namespace TemperatureCalibration
{
    public partial class Main : Form
    {
        CottonTestCore.InterfaceCore core = new InterfaceCore();
        public Main()
        {
            InitializeComponent();
            new ConsoleHelper(textBox1);
        }

        private void ButtonConnect_Click(object sender, EventArgs e)
        {
            try
            {
                core.connect(TextIP.Text, int.Parse(TextPort.Text));
                if (core.connected)
                {
                    buttonReset.Enabled = true;
                    ButtonStartStop.Enabled = true;
                }
                else
                {
                    Console.WriteLine("连接失败");
                }
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

        }

        private void ButtonStartStop_Click(object sender, EventArgs e)
        {
            ButtonStartStop.Text = timer1.Enabled ? "开始" : "停止";
            timer1.Enabled = !timer1.Enabled;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            try
            {
                if (!core.connected)
                    throw new Exception("服务器未连接");
                {
                    uint address = 0xff71 + (uint)0;
                    var re = core.WriteReadReg(address);
                    var x = BitConverter.ToUInt32(re.data, 8);
                    textBox52.Text = x.ToString();
                    textBox53.Text = InterfaceCore.TEMPERATUE.cal_voltage(x, int.Parse(textBox51.Text)).ToString();
                    textBox54.Text = InterfaceCore.TEMPERATUE.cal(x, int.Parse(textBox51.Text)).ToString();
                }
                {
                    uint address = 0xff71 + (uint)1;
                    var re = core.WriteReadReg(address);
                    var x = BitConverter.ToUInt32(re.data, 8);
                    textBox62.Text = x.ToString();
                    textBox63.Text = InterfaceCore.TEMPERATUE.cal_voltage(x, int.Parse(textBox61.Text)).ToString();
                    textBox64.Text = InterfaceCore.TEMPERATUE.cal(x, int.Parse(textBox61.Text)).ToString();
                }
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
