using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReadThenDisplay
{
    class Program
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            string input;//變數 名稱
            Console.WriteLine("請輸入文字");//輸入括弧號內文字
            input = Console.ReadLine();//變數存入輸入文字
            Console.Write("請輸入的文字是:");
            Console.WriteLine(input); //顯示出輸出文字為變數
            Console.ReadLine();//稍等

        }
    }
}
