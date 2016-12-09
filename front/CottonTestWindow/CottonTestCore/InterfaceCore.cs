using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CottonTestCore
{
    public class InterfaceCore
    {
        public const double UNDEF = 9999999;
        public static class TEMPERATUE
        {
            public const double VREF_R = 1.2;
            public const double VREF_AD = 3.3;
            public const long AD_MAX = (1 << 10) - 1;

            /// <summary>
            /// x : Temperature, ℃.
            /// y : Thermistor Resistance, Ω.
            /// log10(y) = a*x^2+bx+c.
            /// </summary>
            public static class POLY3
            {

                public const double A = 9.0047e-5;
                public const double B = -0.01814533;
                public const double C = 4.3745978;
                public static double calx(double y)
                {
                    return (-B - Math.Sqrt(B * B - 4 * A * (C - Math.Log10(y)))) / (2 * A);
                }
                public static double caly(double x)
                {
                    return Math.Pow(10, A * x * x + B * x + C);
                }
            }
            /// <summary>
            /// Not Recommended.
            /// x : Temperature, ℃.
            /// y : Thermistor Resistance, Ω.
            /// log10(y) = ax+b.
            /// </summary>
            public static class LINEAR
            {
                public const double A = -0.018744142;
                public const double B = 4.4376757;
                public static double calx(double y)
                {
                    return (Math.Log10(y) - B) / A;
                }
                public static double caly(double x)
                {
                    return Math.Pow(10, A * x + B);
                }
            }
  
            /// <summary>
            /// Better performance on a "Consolas" font.
            /// Unit: kΩ
            /// VREF_R
            /// |
            /// |-----
            /// |    |
            /// RX   R2         VREF_AD
            /// |----+--->--(-)    |
            /// |    |     RW-->--ADC----(0~AD_MAX)
            /// |    |--->--(+)    |
            /// R1   R3           GND
            /// |-----
            /// GND
            /// </summary>
            /// <returns></returns>
            public static double cal(long ad_output, double RW = 100, string METHOD = "poly3",
                double R1 = 10, double R2 = 10, double R3 = 10)
            {
                if (RW <= 0 || ad_output == AD_MAX)
                    return UNDEF;
                double ad_input = ((double)ad_output / AD_MAX) * VREF_AD;
                double v_r2r3 = VREF_R * R3 / (R2 + R3);
                double v_rxr1 = v_r2r3 - ad_input / ((double)10 / 3 + 1 / RW * 200 / 3);
                double rx = R1 * (VREF_R / v_rxr1 - 1);
                double ret;
                if (METHOD == "linear")
                    ret = LINEAR.calx(rx * 1000);
                else
                    ret = POLY3.calx(rx * 1000);
                return ret;
            }

            public static long cal_inv(double temperature, double RW = 100, string METHOD = "poly3",
                double R1 = 10, double R2 = 10, double R3 = 10)
            {
                double rx;
                if (METHOD == "linear")
                    rx = LINEAR.caly(temperature) / 1000;
                else
                    rx = POLY3.caly(temperature) / 1000;
                double v_rxr1 = VREF_R * R1 / (rx + R1);
                double v_r2r3 = VREF_R * R3 / (R2 + R3);
                double ad_input = ((double)10 / 3 + 1 / RW * 200 / 3) * (v_r2r3 - v_rxr1);
                if (ad_input >= AD_MAX)
                    ad_input = AD_MAX;
                else if (ad_input <= 0)
                    ad_input = 0;
                long ret = (long)Math.Round((ad_input / VREF_AD) * AD_MAX);
                return ret;
            }

        }
        public static class PHOTODIODE
        {
            public const double VREF_AD = 3.3;
            public const double VREF_R = 5;

            public const long AD_MAX = (1 << 12) - 1;
            public const double OFFSET1 = 0;
            public const double AMP1 = 6;
            public const double OFFSET2 = 0;
            public const double AMP2 = 6;
            public const double OFFSET3 = 0;
            public const double AMP3_R = 150;
            public const double AMP3_RL_MAX = 10;
            public const int AMP3_RL_STEP_MAX = 16;
            public const double SPLIT_RATIO = 0.5;

            public static double cal(long ad_output, double amp3_rl = 10)
            {
                if (amp3_rl <= 0 || ad_output >= AD_MAX || amp3_rl >= AMP3_RL_MAX)
                    return UNDEF;
                double ad_input = (double)ad_output / AD_MAX * VREF_AD;
                double v3_in = ad_input / SPLIT_RATIO / ((AMP3_R + amp3_rl) / amp3_rl);
                double v2_in = (v3_in - OFFSET3) / AMP2;
                double v1_in = (v2_in - OFFSET2) / AMP1;
                double ret = v1_in - OFFSET1;
                return ret;
            }
        }

        /// <summary>
        /// 获取当前连接状态
        /// </summary>
        public bool connected
        {
            get
            {
                return c.connected;
            }
        }

        /// <summary>
        /// 是否打印从服务器收到的数据
        /// </summary>
        public bool print_received = true;

        /// <summary>
        /// 连接服务器
        /// </summary>
        /// <param name="ip_address"></param>
        /// <param name="port"></param>
        /// <returns></returns>
        public bool connect(string ip_address, int port = 986)
        {
            return c.connect(System.Net.IPAddress.Parse(ip_address), port);
        }

        /// <summary>
        /// 不推荐外界调用此函数
        /// </summary>
        /// <param name="address"></param>
        /// <param name="read"></param>
        /// <param name="value"></param>
        /// <returns></returns>
        public Client.ReceiveEventArgs WriteReadReg(uint address, bool read = true, uint value = 0)
        {
            if (!connected)
                throw new Exception("服务器未连接");
            List<byte[]> to_send = new List<byte[]>();
            to_send.Add(new byte[] { (read)?(byte)'G':(byte)'S', (byte)'E', (byte)'T', (byte)'X' });
            to_send.Add(BitConverter.GetBytes(address));
            to_send.Add(BitConverter.GetBytes((read) ? 0 : value));
            to_send.Add(BitConverter.GetBytes(0));
            var re = c.send_and_receive_sync(Client.byte_connect(to_send));
            if (BitConverter.ToUInt32(re.data, 4) == 0)
                throw new Exception("读写寄存器失败");
            print_rev(re);
            return re;
        }

        /// <summary>
        /// 获取板实际温度
        /// </summary>
        /// <param name="num">0,1</param>
        /// <returns></returns>
        public double GetTemperature(int num)
        {
            if (!connected)
                throw new Exception("服务器未连接");
            uint address = 0xff71 + (uint)num;
            var re = WriteReadReg(address);
            return TEMPERATUE.cal(BitConverter.ToUInt32(re.data, 8));
        }

        /// <summary>
        /// 获取/设置板设定温度
        /// </summary>
        /// <param name="num">0,1</param>
        /// <param name="set"></param>
        /// <param name="temperature">Unit:℃</param>
        /// <returns></returns>
        public double GetSetTemperature(int num, bool set = false, double temperature = -20)
        {
            if (!connected)
                throw new Exception("服务器未连接");
            uint address = 0xff73 + (uint)num;
            Client.ReceiveEventArgs re;
            if (set)
                re = WriteReadReg(address, false, (uint)TEMPERATUE.cal_inv(temperature));
            else
                re = WriteReadReg(address);
            return TEMPERATUE.cal(BitConverter.ToUInt32(re.data, 8));
        }

        /// <summary>
        /// 获取/设置制冷开关状态
        /// </summary>
        /// <param name="num">0,1</param>
        /// <param name="set"></param>
        /// <param name="open"></param>
        /// <returns></returns>
        public bool GetSetCooler(int num, bool set = false, bool open = true)
        {
            if (!connected)
                throw new Exception("服务器未连接");
            uint address = 0xff75 + (uint)num;
            Client.ReceiveEventArgs re;
            if (set)
                re = WriteReadReg(address, false, (uint)(open ? 1 : 0));
            else
                re = WriteReadReg(address);
            return (BitConverter.ToUInt32(re.data, 8) != 0);
        }

        /// <summary>
        /// 获取/设置可调电阻阻值位阶
        /// </summary>
        /// <param name="num">0,1</param>
        /// <param name="set"></param>
        /// <param name="value">当前阻值位阶</param>
        /// <param name="MAX_VALUE">最大阻值位阶</param>
        /// <returns></returns>
        public uint GetSetRisistor(int num, bool set = false,
            int value = PHOTODIODE.AMP3_RL_STEP_MAX, int MAX_VALUE = PHOTODIODE.AMP3_RL_STEP_MAX)
        {
            if (!connected)
                throw new Exception("服务器未连接");
            if (value < MAX_VALUE)
                throw new Exception("设置的电阻值超过了能提供的最大值");
            uint address = 0xff77 + (uint)num;
            Client.ReceiveEventArgs re;
            if (set)
                re = WriteReadReg(address, false, (uint)value);
            else
                re = WriteReadReg(address);
            return BitConverter.ToUInt32(re.data, 8);
        }

        /// <summary>
        /// 获取/设置数据采集周期（频率）
        /// 单位：Hz
        /// </summary>
        /// <param name="set"></param>
        /// <param name="freq">周期</param>
        /// <returns></returns>
        public uint GetSetPeriod(bool set = false, int freq = 128)
        {
            if (!connected)
                throw new Exception("服务器未连接");
            uint address = 0xff79;
            Client.ReceiveEventArgs re;
            if (set)
                re = WriteReadReg(address, false, (uint)freq);
            else
                re = WriteReadReg(address);
            return BitConverter.ToUInt32(re.data, 8);
        }

        /// <summary>
        /// 获取/设置数据采集宽度
        /// 单位：AD的时钟
        /// </summary>
        /// <param name="set"></param>
        /// <param name="width">宽度</param>
        /// <returns></returns>
        public uint GetSetWidth(bool set = false, int width = 128)
        {
            if (!connected)
                throw new Exception("服务器未连接");
            uint address = 0xff80;
            Client.ReceiveEventArgs re;
            if (set)
                re = WriteReadReg(address, false, (uint)width);
            else
                re = WriteReadReg(address);
            return BitConverter.ToUInt32(re.data, 8);
        }

        /// <summary>
        /// 获取/设置触发状态
        /// </summary>
        /// <param name="set"></param>
        /// <param name="trigger"></param>
        /// <returns></returns>
        public bool GetSetTrigger(bool set = false, bool trigger = true)
        {
            if (!connected)
                throw new Exception("服务器未连接");
            uint address = 0xff81;
            Client.ReceiveEventArgs re;
            if (set)
                re = WriteReadReg(address, false, (uint)(trigger ? 1 : 0));
            else
                re = WriteReadReg(address);
            return (BitConverter.ToUInt32(re.data, 8) != 0);
        }

        /// <summary>
        /// 获取传感器当前输入
        /// </summary>
        /// <param name="cal">是否进行电压反算</param>
        /// <returns></returns>
        public KeyValuePair<double, double> GetData(bool cal = true, double r1 = PHOTODIODE.AMP3_RL_MAX, double r2 = PHOTODIODE.AMP3_RL_MAX)
        {
            if (!connected)
                throw new Exception("服务器未连接");
            List<byte[]> to_send = new List<byte[]>();
            to_send.Add(new byte[] { (byte)'R', (byte)'A', (byte)'W', (byte)'X' });
            to_send.Add(BitConverter.GetBytes(0));
            to_send.Add(BitConverter.GetBytes(0));
            to_send.Add(BitConverter.GetBytes(0));
            var re = c.send_and_receive_sync(Client.byte_connect(to_send));
            print_rev(re);
            //请注意：此处将三对数据做了平均
            uint x1 = (uint)((BitConverter.ToUInt16(re.data, 4) + BitConverter.ToUInt16(re.data, 8) + BitConverter.ToUInt16(re.data, 12)) / 3.0);
            uint x2 = (uint)((BitConverter.ToUInt16(re.data, 6) + BitConverter.ToUInt16(re.data, 10) + BitConverter.ToUInt16(re.data, 14)) / 3.0);
            if (!cal)
                return new KeyValuePair<double, double>(x1, x2);
            else
                return new KeyValuePair<double, double>(PHOTODIODE.cal(x1, r1), PHOTODIODE.cal(x2, r2));
        }

        Client c = new Client();
        void print_rev(Client.ReceiveEventArgs arg)
        {
            if (print_received)
            {
                Console.WriteLine(arg.time.ToString());
                Console.WriteLine(Encoding.ASCII.GetString(arg.data, 0, 4) + ":");
                string tmp = "";
                string tmp2;
                tmp += "0x";
                tmp2 = Convert.ToString(BitConverter.ToInt32(arg.data, 4), 16);
                for (int i = 0; i < 8 - tmp2.Length; i++)
                    tmp += "0";
                tmp += tmp2;
                tmp += " 0x";
                tmp2 = Convert.ToString(BitConverter.ToInt32(arg.data, 8), 16);
                for (int i = 0; i < 8 - tmp2.Length; i++)
                    tmp += "0";
                tmp += tmp2;
                tmp += " 0x";
                tmp2 = Convert.ToString(BitConverter.ToInt32(arg.data, 12), 16);
                for (int i = 0; i < 8 - tmp2.Length; i++)
                    tmp += "0";
                tmp += tmp2;
                Console.WriteLine(tmp);
            }
        }
    }
}
