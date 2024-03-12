using server.cards;
using server.data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace server.servermain
{
    internal class usecard
    {
        public static void use(List<string> strings, int user)
        {
            strings[0] = (int.Parse(strings[0]) - 1).ToString();
            int place = int.Parse(strings[0]);
            if (user == 1)
            {
                strings[0] = usercardsinfo.user1cards[int.Parse(strings[0])].ToString();
            }
            else
            {
                strings[0] = usercardsinfo.user2cards[int.Parse(strings[0])].ToString();
            }
            string slotion;
            if (int.Parse(strings[0]) == 10001) { slotion = cardsattribute.c10001(strings); }
            else if (int.Parse(strings[0]) == 20001) { slotion = cardsattribute.c20001(strings); }
            else if (int.Parse(strings[0]) == 20001) { slotion = cardsattribute.c30001(strings); }
            else if (int.Parse(strings[0]) == 20001) { slotion = cardsattribute.c40001(strings); }
            else if (int.Parse(strings[0]) == 20001) { slotion = cardsattribute.c50001(strings); }
            else if (int.Parse(strings[0]) == 20001) { slotion = cardsattribute.c60001(strings); }

            else { slotion = "unsuccess"; }

            if (slotion == "unsuccess")
            {
                if (user == 1)
                {
                    server.session1.Send("mes 卡牌使用失败");
                }
                else if (user == 2)
                {
                    server.session2.Send("mes 卡牌使用失败");
                }

            }
            else
            {
                if (user == 1)
                {
                    usercardsinfo.user1cards[place] = 0;
                    server.session1.Send("mes 卡牌使用成功");
                }
                else if (user == 2)
                {
                    usercardsinfo.user2cards[place]=0;
                    server.session2.Send("mes 卡牌使用成功");
                }

            }

        }
    }

    class cardsattribute
    {
        public static string c10001(List<string> strings)
        {
            string output = "success";
            strings[1] = Trn.trn(strings[1]);
            strings[2] = Trn.trn(strings[2]);
            int dmg = 0;
            int spd = 0;
            int x = 0;
            int y = 0;
            if (strings[1] == "qinglong")
            {
                dmg = maindata.qinglong.damage;
                spd = maindata.qinglong.speed;
                x = maindata.qinglong.x;
                y = maindata.qinglong.y;
            }
            else if (strings[1] == "baihu")
            {
                dmg = maindata.baihu.damage;
                spd = maindata.baihu.speed;
                x = maindata.baihu.x;
                y = maindata.baihu.y;
            }
            else if (strings[1] == "zhuque")
            {
                dmg = maindata.zhuque.damage;
                spd = maindata.zhuque.speed;
                x = maindata.zhuque.x;
                y = maindata.zhuque.y;
            }
            else if (strings[1] == "xuanwu")
            {
                dmg = maindata.xuanwu.damage;
                spd = maindata.xuanwu.speed;
                x = maindata.xuanwu.x;
                y = maindata.xuanwu.y;
            }

            else if (strings[1] == "hundun")
            {
                dmg = maindata.hundun.damage;
                spd = maindata.hundun.speed;
                x = maindata.hundun.x;
                y = maindata.hundun.y;
            }
            else if (strings[1] == "qiongqi")
            {
                dmg = maindata.qiongqi.damage;
                spd = maindata.qiongqi.speed;
                x = maindata.qiongqi.x;
                y = maindata.qiongqi.y;
            }
            else if (strings[1] == "taowu")
            {
                dmg = maindata.taowu.damage;
                spd = maindata.taowu.speed;
                x = maindata.taowu.x;
                y = maindata.taowu.y;
            }
            else if (strings[1] == "taotie")
            {
                dmg = maindata.taotie.damage;
                spd = maindata.taotie.speed;
                x = maindata.taotie.x;
                y = maindata.taotie.y;
            }
            else
            {
                output = "unsuccess";
            }

            if (strings[2] == "qinglong")
            {
                if (spd < Math.Abs(maindata.qinglong.x - x) + Math.Abs(maindata.qinglong.y - y))
                {
                    return "unsuccess";
                }
                maindata.qinglong.damaged(dmg, strings[1]);
            }
            else if (strings[2] == "baihu")
            {
                if (spd < Math.Abs(maindata.baihu.x - x) + Math.Abs(maindata.baihu.y - y))
                {
                    return "unsuccess";
                }
                maindata.baihu.damaged(dmg, strings[1]);
            }
            else if (strings[2] == "zhuque")
            {
                if (spd < Math.Abs(maindata.zhuque.x - x) + Math.Abs(maindata.zhuque.y - y))
                {
                    return "unsuccess";
                }
                maindata.zhuque.damaged(dmg, strings[1]);
            }
            else if (strings[2] == "xuanwu")
            {
                if (spd < Math.Abs(maindata.xuanwu.x - x) + Math.Abs(maindata.xuanwu.y - y))
                {
                    return "unsuccess";
                }
                maindata.xuanwu.damaged(dmg, strings[1]);
            }
            else if (strings[2] == "hundun")
            {
                if (spd < Math.Abs(maindata.hundun.x - x) + Math.Abs(maindata.hundun.y - y))
                {
                    return "unsuccess";
                }
                maindata.hundun.damaged(dmg, strings[1]);
            }
            else if (strings[2] == "qiongqi")
            {
                if (spd < Math.Abs(maindata.qiongqi.x - x) + Math.Abs(maindata.qiongqi.y - y))
                {
                    return "unsuccess";
                }
                maindata.qiongqi.damaged(dmg, strings[1]);
            }
            else if (strings[2] == "taowu")
            {
                if (spd < Math.Abs(maindata.taowu.x - x) + Math.Abs(maindata.taowu.y - y))
                {
                    return "unsuccess";
                }
                maindata.taowu.damaged(dmg, strings[1]);
            }
            else if (strings[2] == "taotie")
            {
                if (spd < Math.Abs(maindata.taotie.x - x) + Math.Abs(maindata.taotie.y - y))
                {
                    return "unsuccess";
                }
                maindata.taotie.damaged(dmg, strings[1]);
            }
            else
            {
                output = "unsuccess";
            }
            return output;

        }
        public static string c20001(List<string> strings)
        {
            string output = "success";
            return output;
        }
        public static string c30001(List<string> strings)
        {
            string output = "success";
            return output;

        }
        public static string c40001(List<string> strings)
        {
            string output = "success";
            return output;

        }
        public static string c50001(List<string> strings)
        {
            string output = "success";
            return output;

        }
        public static string c60001(List<string> strings)
        {
            string output = "success";
            return output;

        }
        public static void c69999(List<string> strings)
        {

        }
        public static void c20002(List<string> strings)
        {

        }
        public static void c30002(List<string> strings)
        {

        }
        public static void c40002(List<string> strings)
        {

        }
        public static void c50002(List<string> strings)
        {

        }

    }
}
