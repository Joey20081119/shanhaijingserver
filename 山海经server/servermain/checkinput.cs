using server.cards;
using server.data;
using SuperSocket.SocketBase;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using 山海经server.servermain;

namespace server.servermain
{
    internal class checkinput
    {
        public static string check(AppSession session,string key,string body,int user)
        {
            string output = null;
            if (key == "getacard")
            {

                try
                {
                    int output1 = getacard.getcard(int.Parse(body));
                    Console.WriteLine("用户" + session.RemoteEndPoint.ToString() + "获取卡牌，id：" + output1);
                    if (user == 1)
                    {
                        Console.WriteLine( usercardsinfo.user1addcards(output1));
                    }
                    if (user == 2)
                    {
                        Console.WriteLine( usercardsinfo.user2addcards(output1));
                    }
                    output = "getcard " + output1;
                }
                catch
                {
                    Console.WriteLine("非法数据，语法：getacard int");
                    output="非法数据，语法：getacard int";
                }
            }
            else if (key == "shenshou")
            {
                List<string> strings=body.Split(new char[] {char.Parse(" ")},StringSplitOptions.RemoveEmptyEntries).ToList();
                if (strings[0] == "moveto")
                {
                    if (user == 2)
                    {
                        strings[1] = Trn.trn(strings[1]);
                        strings[2] = (9 - int.Parse(strings[2])).ToString();
                        strings[3] = (9 - int.Parse(strings[3])).ToString();
                    }
                    if (strings[1] =="qinglong")
                    {
                        maindata.qinglong.x = int.Parse(strings[2]);
                        maindata.qinglong.y = int.Parse(strings[3]);
                        maindata.qinglong.moved = false;
                    }
                    if (strings[1] == "baihu")
                    {
                        maindata.baihu.x = int.Parse(strings[2]);
                        maindata.baihu.y = int.Parse(strings[3]);
                        maindata.baihu.moved = false;
                    }
                    if (strings[1] == "zhuque")
                    {
                        maindata.zhuque.x = int.Parse(strings[2]);
                        maindata.zhuque.y= int.Parse(strings[3]);
                        maindata.zhuque.moved = false;
                    }
                    if (strings[1] == "xuanwu")
                    {
                        maindata.xuanwu.x = int.Parse(strings[2]);
                        maindata.xuanwu.y = int.Parse(strings[3]);
                        maindata.xuanwu.moved = false;
                    }
                    if (strings[1] == "hundun")
                    {
                        maindata.hundun.x = int.Parse(strings[2]);
                        maindata.hundun.y = int.Parse(strings[3]);
                        maindata.hundun.moved = false;
                    }
                    if (strings[1] == "qiongqi")
                    {
                        maindata.qiongqi.x = int.Parse(strings[2]);
                        maindata.qiongqi.y = int.Parse(strings[3]);
                        maindata.qiongqi.moved = false;
                    }
                    if (strings[1] == "taowu")
                    {
                        maindata.taowu.x = int.Parse(strings[2]);
                        maindata.taowu.y = int.Parse(strings[3]);
                        maindata.taowu.moved = false;
                    }
                    if (strings[1] == "taotie")
                    {
                        maindata.taotie.x = int.Parse(strings[2]);
                        maindata.taotie.y = int.Parse(strings[3]);
                        maindata.taotie.moved = false;
                    }

                }
            }

            else if (key == "usecard")
            {
                List<string> strings = body.Split(new char[] { char.Parse(" ") }, StringSplitOptions.RemoveEmptyEntries).ToList();
                usecard.use(strings);
            }
            else if (key == "")
            {

            }
            return output;
        }
    }
}
