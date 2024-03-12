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
            else if (input == "hundun")
            {
                input = "qinglong";
            }
            else if (input == "qiongqi")
            {
                input = "baihu";
            }
            else if (input == "taowu")
            {
                input = "zhuque";
            }
            else if (input == "taotie")
            {
                input = "xuanwu";
            }
            return input;

        }
        public static string trn2(string input)
        {
            if (input == "qinglong")
            {
                input = "青龙";
            }
            else if (input == "baihu")
            {
                input = "白虎";
            }
            else if (input == "zhuque")
            {
                input = "朱雀";
            }
            else if (input == "xuanwu")
            {
                input = "玄武";
            }
            else if (input == "hundun")
            {
                input = "混沌";
            }
            else if (input == "qiongqi")
            {
                input = "穷奇";
            }
            else if (input == "taowu")
            {
                input = "梼杌";
            }
            else if(input =="taotie")
            {
                input = "饕餮";
            }
                return input;
        }

    }
}
