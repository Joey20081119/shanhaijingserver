using System;
using System.Security.Cryptography;

namespace server.cards
{
    public class RandomNumberGenerator
    {
        public static int GenerateRandomNumber(int num1, int num2)
        {
            // 确保num1小于num2
            if (num1 > num2)
            {
                int temp = num1;
                num1 = num2;
                num2 = temp;
            }

            // 创建一个随机数生成器对象
            using (RNGCryptoServiceProvider rng = new RNGCryptoServiceProvider())
            {
                byte[] randomNumber = new byte[4]; // 生成一个4字节的随机数

                // 使用随机数生成器填充byte数组
                rng.GetBytes(randomNumber);

                // 将byte数组转换为整数
                int randomInt = BitConverter.ToInt32(randomNumber, 0);

                // 将随机数映射到num1和num2之间
                return num1 + Math.Abs(randomInt % (num2 - num1 + 1));
            }
        }
    }
}