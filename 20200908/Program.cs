﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20200908
{
    class Program
    {
        static void Main(string[] args)
        {
            Random vel = new Random();
            string[] lehetoseg = new string[] { "Kő", "Papír", "Olló" };
            int gepValasz = vel.Next(0, 3);
            Console.WriteLine("Gép Választása: {0}",lehetoseg[gepValasz]);

            
            Console.ReadKey();
        }
    }
}
