using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace server.cards
{
    internal class getacard
    {
        private static int card1percent =300;
        private static int card2percent = 300;
        private static int card3percent = 200;
        private static int card4percent = 150;
        private static int card5percent = 45;
        private static int card6percent = 5;
        private static int card1sum = 1;
        private static int card2sum = 1;
        private static int card3sum = 1;
        private static int card4sum = 1;
        private static int card5sum = 1;
        private static int card6sum = 1;



        public static int getcard(int input)
        {
            int output=input;
            if (input == 0)
            {
                int output1 = RandomStar();
                output = RamdomCards(output1);

            }
            else if (input <= 6)
            {
                output = RamdomCards(input);
            }

            return output;
        }

        private static int RandomStar()
        {
            int output = RandomNumberGenerator.GenerateRandomNumber(1, card1percent + card2percent + card3percent + card4percent + card5percent + card6percent );
            if (output <= card1percent)
            {
                output = 1;
            }
            else if (output <= card1percent + card2percent)
            {
                output = 2;
            }
            else if (output <= card1percent + card2percent + card3percent)
            {
                output = 3;
            }
            else if (output <= card1percent + card2percent + card3percent + card4percent)
            {
                output = 4;
            }
            else if (output <= card1percent + card2percent + card3percent + card4percent + card5percent)
            {
                output = 5;
            }
            else
            {
                output = 6;
            }
            return output;
        }
        private static int RamdomCards(int input)
        {
            int star = input;
            if (input == 1)
            {
                input = RandomNumberGenerator.GenerateRandomNumber(1, card1sum);
            }
            else if (input == 2)
            {
                input = RandomNumberGenerator.GenerateRandomNumber(1, card2sum);
            }
            else if (input == 3)
            {
                input = RandomNumberGenerator.GenerateRandomNumber(1, card3sum);
            }
            else if (input == 4)
            {
                input = RandomNumberGenerator.GenerateRandomNumber(1, card4sum);
            }
            else if (input == 5)
            {
                input = RandomNumberGenerator.GenerateRandomNumber(1, card5sum);
            }
            else if (input == 6)
            {
                input = RandomNumberGenerator.GenerateRandomNumber(1, card6sum);
            }
            else
            {
                Console.WriteLine("unknow stars");
            }
            input = 10000 * star + input;
            return input;
        }
    }
}
