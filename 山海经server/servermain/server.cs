using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Sockets;
using server.cards;
using System.Reflection;
using System.Threading;
using SuperSocket.SocketBase;
using server.servermain;
using server.data;

namespace server
{
    internal class server
    {
        public static AppSession session1;
        public static AppSession session2;


        public static Socket socket = new Socket(AddressFamily.InterNetwork,SocketType.Stream,ProtocolType.Tcp);

        static void Main()
        {
            Parallel.Invoke(Main1, usercardsinfo.Main2,maindata.Main3);
        }
        static void Main1()
        {

            var appServer1 = new AppServer();
            var appServer2 = new AppServer();

            if (!appServer1.Setup(25565)||!appServer2.Setup(25566)) 
            {
                Console.WriteLine("初始化失败！");
                Console.ReadKey();
                return;
            }

            if (!appServer1.Start()||!appServer2.Start())
            {
                Console.WriteLine("启动失败！");
                Console.ReadKey();
                return;
            }

            Console.WriteLine("服务器启动成功，按Q关闭服务器");

            appServer1.NewSessionConnected += AppServer1_NewSessionConnected;
            appServer1.SessionClosed += AppServer1_SessionClosed;
            appServer1.NewRequestReceived += AppServer1_NewRequestReceived;
            appServer2.NewSessionConnected += AppServer2_NewSessionConnected;
            appServer2.SessionClosed += AppServer2_SessionClosed;
            appServer2.NewRequestReceived += AppServer2_NewRequestReceived;

            while (Console.ReadKey().KeyChar != 'q')
            {
                Console.WriteLine();
                continue;
            }

            appServer1.Stop();
            appServer2.Stop();

            Console.WriteLine("服务器已关闭！");
            Console.ReadKey();
        }

        private static void AppServer2_NewRequestReceived(AppSession session, SuperSocket.SocketBase.Protocol.StringRequestInfo requestInfo)
        {
            session2 = session;
            string key = requestInfo.Key;
            string body = requestInfo.Body;
            string sendmes=checkinput.check(session,key, body,2);
            session.Send(sendmes);
        }

        private static void AppServer2_SessionClosed(AppSession session, CloseReason value)
        {
            Console.WriteLine("客户端2已断开！客户端ip：" + session.RemoteEndPoint.ToString() + value);
        }

        private static void AppServer2_NewSessionConnected(AppSession session)
        {
            session2 = session;
            Console.WriteLine("客户端2已连接！客户端ip：" + session.RemoteEndPoint.ToString());
            while (true)
            {
                for (int i = 0; i < 58; i++)
                {
                    Thread.Sleep(17);
                    session.Send("linking");
                }
                maindata.user2senddata(session);
            }

        }

        private static void AppServer1_NewRequestReceived(AppSession session, SuperSocket.SocketBase.Protocol.StringRequestInfo requestInfo)
        {
            session1=session;
            string key = requestInfo.Key;
            string body = requestInfo.Body;
            string sendmes = checkinput.check(session, key, body,1);
            session.Send(sendmes);

        }

        private static void AppServer1_SessionClosed(AppSession session, CloseReason value)
        {
            Console.WriteLine("客户端1已断开！客户端ip：" + session.RemoteEndPoint.ToString()+value);
        }

        private static void AppServer1_NewSessionConnected(AppSession session)
        {
            session1 = session;
            Console.WriteLine("客户端1已连接！客户端ip："+session.RemoteEndPoint.ToString());
            while(true)
            {
                for (int i = 0; i < 58; i++)
                {
                    Thread.Sleep(17);
                    session.Send("linking");
                }
                maindata.user1senddata(session);
            }
        }
    }
}
