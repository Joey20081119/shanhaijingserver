using SuperSocket.SocketBase;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace server.data
{
    internal class maindata
    {
        public static shenshouAttribute qinglong = new shenshouAttribute();
        public static shenshouAttribute baihu = new shenshouAttribute();
        public static shenshouAttribute zhuque = new shenshouAttribute();
        public static shenshouAttribute xuanwu = new shenshouAttribute();
        public static shenshouAttribute hundun = new shenshouAttribute();
        public static shenshouAttribute qiongqi = new shenshouAttribute();
        public static shenshouAttribute taowu = new shenshouAttribute();
        public static shenshouAttribute taotie = new shenshouAttribute();
        public static bool user1round= false;
        public static bool user2round = false;
        public static int round = 0;
        public static bool user1connect= false;
        public static bool user2connect= false;
        public static void Main3()
        {
            qinglong.name1 = "qinglong";
            baihu.name1 = "baihu";
            zhuque.name1 = "zhuque";
            xuanwu.name1 = "xuanwu";
            hundun.name1 = "hundun";
            qiongqi.name1 = "qiongqi";
            taowu.name1 = "taowu";
            taotie.name1 = "taotie";

            qinglong.name2 = "hundun";
            baihu.name2 = "qiongqi";
            zhuque.name2 = "taowu";
            xuanwu.name2 = "taotie";
            hundun.name2 = "qinglong";
            qiongqi.name2 = "baihu";
            taowu.name2 = "zhuque";
            taotie.name2 = "xuanwu";



            baihu.maxhealth = 4;
            baihu.health = 4;
            baihu.damage = 2;
            baihu.misspercent = 20;
            qinglong.armor = 1;
            qinglong.misspercent = 5;
            xuanwu.maxhealth = 12;
            xuanwu.health = 12;
            xuanwu.misspercent = 0;
            zhuque.maxhealth = 3;
            zhuque.health = 3;
            zhuque.speed = 2;
            zhuque.misspercent = 40;

            qiongqi.maxhealth = 4;
            qiongqi.health = 4;
            qiongqi.damage = 2;
            qiongqi.misspercent = 20;
            hundun.armor = 1;
            hundun.misspercent = 5;
            taotie.maxhealth = 12;
            taotie.health = 12;
            taotie.misspercent = 0;
            taowu.maxhealth = 3;
            taowu.health = 3;
            taowu.speed = 2;
            taowu.misspercent = 40;

            qinglong.x = 1;
            baihu.x = 3;
            zhuque.x = 5;
            xuanwu.x = 7;
            hundun.x = 8;
            qiongqi.x = 6;
            taowu.x = 4;
            taotie.x = 2;

            qinglong.y = 1;
            baihu.y = 1;
            zhuque.y = 1;
            xuanwu.y = 1;
            hundun.y = 8;
            qiongqi.y = 8;
            taowu.y = 8;
            taotie.y = 8;

            while (true)
            {
                qinglong.xy = qinglong.x + " " + qinglong.y;
                baihu.xy = baihu.x + " " + baihu.y;
                zhuque.xy = zhuque.x + " " + zhuque.y;
                xuanwu.xy = xuanwu.x + " " + xuanwu.y;
                hundun.xy = hundun.x + " " + hundun.y;
                qiongqi.xy = qiongqi.x + " " + qiongqi.y;
                taowu.xy = taowu.x + " " + taowu.y;
                taotie.xy = taotie.x + " " + taotie.y;
            }
        }
        public static void user1senddata(AppSession session)
        {
            qinglong.user1senddata(session);
            baihu.user1senddata(session);
            zhuque.user1senddata(session);
            xuanwu.user1senddata(session);
            hundun.user1senddata(session);
            qiongqi.user1senddata(session);
            taowu.user1senddata(session);
            taotie.user1senddata(session);
        }
        public static void user2senddata(AppSession session)
        {
            qinglong.user2senddata(session);
            baihu.user2senddata(session);
            zhuque.user2senddata(session);
            xuanwu.user2senddata(session);
            hundun.user2senddata(session);
            qiongqi.user2senddata(session);
            taowu.user2senddata(session);
            taotie.user2senddata(session);
        }

    }
    public class shenshouAttribute
    {
        public string name1 = "1";
        public string name2 = "2";
        public int maxhealth = 6;
        public int health = 6;
        public int damage = 1;
        public int speed = 1;
        public int armor = 0;
        public int misspercent = 10;
        public int x = 0;
        public int y = 0;
        public string xy = "0 0";
        public bool moved=false;

        public void user1senddata(AppSession session)
        {
            session.Send("shenshou" + " " + name1 + " " + maxhealth + " " + health + " " + damage + " " + speed + " " + armor + " " + misspercent + " " + xy+" "+moved);
        }
        public void user2senddata(AppSession session)
        {
            session.Send("shenshou" + " " + name2 + " " + maxhealth + " " + health + " " + damage + " " + speed + " " + armor + " " + misspercent + " " + (9-x)+" "+(9-y)+" "+moved);
        }

    }

}
