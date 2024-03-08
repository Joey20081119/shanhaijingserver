using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace server.data
{
    internal class Trn
    {
        public static string trn(string input)
        {
            if (input == "qinglong")
            {
                input = "hundun";
            }
            else if (input == "baihu")
            {
                input = "qiongqi";
            }
            else if (input == "zhuque")
            {
                input = "taowu";
            }
            else if (input == "xuanwu")
            {
                input = "taotie";
            }
            return input;
        }
    }
}
