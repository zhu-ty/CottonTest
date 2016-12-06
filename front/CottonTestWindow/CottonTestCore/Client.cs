using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Sockets;
using System.Net;
using System.Threading;
using System.IO;

namespace CottonTestCore
{
    public class Client
    {
        public static byte[] byte_connect(List<byte[]> btlist)
        {
            int length = 0;
            int now = 0;
            for (int i = 0; i < btlist.Count; i++)
                length += btlist[i].Length;
            byte[] ret = new byte[length];
            for (int i = 0; i < btlist.Count; i++)
            {
                Array.Copy(btlist[i], 0, ret, now, btlist[i].Length);
                now += btlist[i].Length;
            }
            return ret;
        }

        /// <summary>
        /// 连接最长等待时间
        /// </summary>
        public const int max_connect_senconds = 10;
        /// <summary>
        /// 回包数据长度
        /// </summary>
        public const int data_len = 16;

        public const int CONST_PORT = 986;


        public bool connect(IPAddress target_ip,int listen_port = CONST_PORT)
        {
            //socket_lock.WaitOne();
            socket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            IAsyncResult connect_result = socket.BeginConnect(target_ip, listen_port, null, null);
            connect_result.AsyncWaitHandle.WaitOne(max_connect_senconds * 1000);//10s
            if (!connect_result.IsCompleted)
            {
                socket.Close();
                return false;
            }
            //socket_lock.ReleaseMutex();
            return true;
        }

        public ReceiveEventArgs send_and_receive_sync(byte[] buffer)
        {
            ReceiveEventArgs ret = new ReceiveEventArgs();
            try
            {
                socket.Send(buffer);
                byte[] rec_buf = new byte[data_len];
                socket.Receive(rec_buf);
                ret.data = rec_buf;
                ret.time = DateTime.Now;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            return ret;
        }

        public async Task<ReceiveEventArgs> send_and_receive(byte[] buffer)
        {
            ReceiveEventArgs ret = new ReceiveEventArgs();
            try
            {
                socket.Send(buffer);
                byte[] rec_buf = new byte[data_len];
                await Task.Run(()=>
                {
                    socket.Receive(rec_buf);
                });
                ret.data = rec_buf;
                ret.time = DateTime.Now;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            return ret;
        }


        public class ReceiveEventArgs
        {
            public byte[] data;
            public DateTime time;
        }

        public bool connected
        {
            get
            {
                if (socket == null)
                    return false;
                bool connectState = true;
                bool blockingState = socket.Blocking;
                try
                {
                    byte[] tmp = new byte[1];

                    socket.Blocking = false;
                    socket.Send(tmp, 0, 0);
                    connectState = true;
                }
                catch (SocketException e)
                {
                    // 10035 == WSAEWOULDBLOCK
                    if (e.NativeErrorCode.Equals(10035))
                    {
                        connectState = true;
                    }
                    else
                    {
                        connectState = false;
                    }
                }
                finally
                {
                    socket.Blocking = blockingState;
                }

                return connectState;
            }
        }

        private Socket socket;
        
    }
}