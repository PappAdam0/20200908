using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
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
          

            int jatekosValasz;
            Console.WriteLine("Kő (0), Papír (1), Olló (2)");
            Console.Write("Válasz: ");
            jatekosValasz = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Játékos választása: {0}",lehetoseg[jatekosValasz]);
            Console.WriteLine("Gép Választása: {0}", lehetoseg[gepValasz]);

            if (lehetoseg[jatekosValasz]=="Olló" && lehetoseg[gepValasz] == "Kő")
            {
                Console.WriteLine("Veszítettél");
            }
            if (lehetoseg[jatekosValasz] == "Olló" && lehetoseg[gepValasz] == "Papír")
            {
                Console.WriteLine("Nyertél");
            }
            if (lehetoseg[jatekosValasz] == "Olló" && lehetoseg[gepValasz] == "Olló")
            {
                Console.WriteLine("Döntetlen");
            }
            if (lehetoseg[jatekosValasz] == "Kő" && lehetoseg[gepValasz] == "Kő")
            {
                Console.WriteLine("Döntetlen");
            }
            if (lehetoseg[jatekosValasz] == "Kő" && lehetoseg[gepValasz] == "Papír")
            {
                Console.WriteLine("Vesztettél");
            }
            if (lehetoseg[jatekosValasz] == "Kő" && lehetoseg[gepValasz] == "Olló")
            {
                Console.WriteLine("Nyertél");
            }
            if (lehetoseg[jatekosValasz] == "Papír" && lehetoseg[gepValasz] == "Kő")
            {
                Console.WriteLine("Nyertél");
            }
            if (lehetoseg[jatekosValasz] == "Papír" && lehetoseg[gepValasz] == "Papír")
            {
                Console.WriteLine("Döntetlen");
            }
            if (lehetoseg[jatekosValasz] == "Papír" && lehetoseg[gepValasz] == "Olló")
            {
                Console.WriteLine("Vesztettél");
            }


            Console.ReadKey();
        }
    }
}
