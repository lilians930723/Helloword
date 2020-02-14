using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace condition
{
    class Program
    {
        static void Main(string[] args)
        {
            int condition = 10;//預設值。condition，為變數
            //int value;
            Console.WriteLine("請輸入一個數字");//顯示所打出的字串
            string input = Console.ReadLine();//變數設定為你所打入字串
            int value = int.Parse(input);//輸入變數(字串)轉變成數字
            if (value > condition)//輸入數字大於預設值
            {
                Console.WriteLine($"輸入值大於{condition}");//$，把CONDITION帶回所設變數
            }
            else
            {
                if (value < condition)
                {
                    Console.WriteLine($"輸入值小於{condition}");
                }
                else
                {
                    Console.WriteLine($"請輸入值等於{condition}");
                }
                Console.ReadLine();
            }
        }
    }
}
