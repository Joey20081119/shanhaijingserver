using server.data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace server.servermain
{
    internal class game
    {
        public static void Main4()
        {
            while (maindata.user1connect && maindata.user2connect)
            {

            }
            Console.WriteLine("游戏开始！");
            maindata.round = 1;
            maindata.user1round = true;

        }
    }
}
