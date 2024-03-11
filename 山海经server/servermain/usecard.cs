using server.cards;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace server.servermain
{
    internal class usecard
    {
        public static void use(List<string> strings,int user)
        {
            strings[0]=(int.Parse(strings[0]) - 1).ToString();
            if (user == 1)
            {
                strings[0] = usercardsinfo.user1cards[int.Parse(strings[0])].ToString();
            }
            else
            {
                strings[0] = usercardsinfo.user2cards[int.Parse(strings[0])].ToString();
            }

            if (int.Parse(strings[0]) == 10001) { cardsattribute.c10001(strings); }
            else if (int.Parse(strings[0]) == 20001) { cardsattribute.c20001(strings); }
            else if (int.Parse(strings[0]) == 20001) { cardsattribute.c30001(strings); }
            else if (int.Parse(strings[0]) == 20001) { cardsattribute.c40001(strings); }
            else if (int.Parse(strings[0]) == 20001) { cardsattribute.c50001(strings); }
            else if (int.Parse(strings[0]) == 20001) { cardsattribute.c60001(strings); }




        }
    }

    class cardsattribute
    {
        public static void c10001(List<string> strings)
        {

        }
        public static void c20001(List<string> strings)
        {

        }
        public static void c30001(List<string> strings)
        {

        }
        public static void c40001(List<string> strings)
        {

        }
        public static void c50001(List<string> strings)
        {

        }
        public static void c60001(List<string> strings)
        {

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
