using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForLoopSample
{
    class Program
    {
        static void Main(string[] args)
        {
            int result = 0;
            for (int i = 1; i < 11; i++)
            {
                result = result + i;//i小於11就會有左方
            }
            Console.WriteLine($"加總成果 : {result}");
            Console.ReadLine();
        }
    }
}
