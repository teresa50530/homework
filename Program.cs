using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 閏年
{
    class Program
    {
        public static void Main()
        {
            Console.Write("請輸入一個民國年份");
            string i = Console.ReadLine();
            int value = int.Parse(i)+1911;
          
            if (DateTime.IsLeapYear(value) == true)
            {
                Console.WriteLine(value+"為閏年");
            }
            else
            {
                Console.WriteLine(value+"為平年");
            }
            Console.ReadLine();
        }
    }
}
