using System;
using System.Collections.Generic;
using System.Text;

namespace Analytic4Tests
{
    public class TestGenerateData
    {
        public static string GenerateRandomString(int size, bool lowerCase = true)
        {
            StringBuilder stringBuilder = new StringBuilder();
            Random random = new Random();

            char ch;

            for (int i = 0; i < size; i++)
            {
                ch = Convert.ToChar(Convert.ToInt32(Math.Floor(26 * random.NextDouble() + 65)));
                stringBuilder.Append(ch);

            }

            if (lowerCase)
            {
                return stringBuilder.ToString().ToLower();
            }

            return stringBuilder.ToString();
        } 

        public static string GenerateRandomUser(int size = 5)
        {
            string randomUser = GenerateRandomString(size);

            return randomUser;
        }

        public static string GenerateRandomData(int size)
        {
            int[] array = new int[size];
            Random random = new Random();
            string data = "";

            for (int i = 0; i < array.Length; i++)
            {
                array[i] = random.Next(33, 125);
                data += (char)array[i];
            }
            return data;
        }

        public static string GenerateRandomPassword(int size)
        {
            string randomPassword = GenerateRandomData(size);

            return randomPassword;
        }

        public static int GenerateRandomNumber(int minValue, int maxValue)
        {
            var random = new Random();

            return random.Next(minValue, maxValue);
        }
    }
}
