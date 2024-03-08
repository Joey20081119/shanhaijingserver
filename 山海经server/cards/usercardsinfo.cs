using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace server.cards
{
    internal class usercardsinfo
    {
        public static List<int> user1cards = new List<int>();
        public static List<int> user2cards = new List<int>();
        public static int user1cardsum;
        public static int user2cardsum;
        public static void Main2()
        {
            for (int i = 0; i < 8; i++)
            {
                user1cards.Add(0);
                user2cards.Add(0);
            }
            while (true)
            {
                user1cardsum = 0;
                user2cardsum = 0;
                for (int i = 0; i < user1cards.Count; i++)
                {
                    if (user1cards[i] != 0)
                    {
                        user1cardsum++;
                    }
                }
                for (int i = 0; i < user2cards.Count; i++)
                {
                    if (user2cards[i] != 0)
                    {
                        user2cardsum++;
                    }
                }
                Thread.Sleep(1000);
                try
                {
                    server.session1.Send("opposite cardsum " + user2cardsum.ToString());
                }
                catch { }
                try
                {
                    server.session2.Send("opposite cardsum " + user1cardsum.ToString());
                }
                catch { }


            }
        }

        public static string user1addcards(int id)
        {
            int i = 0;
            string output = "unsuccess";
            while (i < user1cards.Count)
            {
                if (user1cards[i] == 0)
                {
                    user1cards[i] = id;
                    output = "success";
                    break;
                }
                i++;
            }
            return output;

        }
        public static string user2addcards(int id)
        {
            int i = 0;
            string output = "unsuccess";
            while (i < user2cards.Count)
            {
                if (user2cards[i] == 0)
                {
                    user2cards[i] = id;
                    output = "success";
                    break;
                }
                i++;
            }
            return output;

        }

    }
}
