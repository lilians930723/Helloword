﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dowhile
{
    class Program
    {
        static void Main(string[] args)
        {
            int result = 0;
            int i = 12;
            do
            {
                result = result + i;
                i= i+ 1;
            }
            while (i < 11);
            Console.WriteLine($"加總結果:{result}");
            Console.ReadLine();


        }
    }
}
