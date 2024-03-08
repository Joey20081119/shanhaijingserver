using server.data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace server.servermain
{
    internal class game
    {
        public static void Main4()
        {
            while (!maindata.user1connect || !maindata.user2connect)
            {

            }
            Console.WriteLine("游戏开始！");
            maindata.round = 1;
            maindata.user1round = true;
            maindata.qinglong.moved = true;
            maindata.baihu.moved = true;
            maindata.zhuque.moved = true;
            maindata.xuanwu.moved = true;
            checkinput.check(server.session1, "getacard", "1", 1);
            checkinput.check(server.session1, "getacard", "2", 1);
            checkinput.check(server.session1, "getacard", "3", 1);
            checkinput.check(server.session2, "getacard", "1", 2);
            checkinput.check(server.session2, "getacard", "2", 2);
            checkinput.check(server.session2, "getacard", "3", 2);

        }
    }
}
