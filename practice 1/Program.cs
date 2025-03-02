using System;

using System.Linq;

namespace practice_1
{
    internal class Program
    {
        static string ProcStr(string str)
        {
            if (str == null)
            {
                return str;
            }

            int strLength = str.Length;

            if (strLength % 2 == 0) 
            {
                int midpoint = strLength / 2;
                string str1 = str.Substring(0,midpoint);
                string str2 = str.Substring(midpoint);
                
                str1= new string(str1.Reverse().ToArray());
                str2 = new string(str2.Reverse().ToArray());

                return str1+str2;
            }
            else
            {
                string reversstr = new string(str.Reverse().ToArray()); 
                return reversstr+str;
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Введите строку:");
            string input = Console.ReadLine();
            string output = ProcStr(input);
            Console.WriteLine("Обработанная строка:" + output);
        }
    }
}
