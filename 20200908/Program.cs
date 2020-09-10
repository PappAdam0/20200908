using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Reflection;

namespace _20200908
{
    class Program
    {
        
        static string[] lehetoseg = new string[] { "Kő", "Papír", "Olló" };

        static int botnyer = 0;
        static int jatekosnyer = 0;
        static int menet = 0;

        static void eredmeny_kiiras(int gep, int ember)
        {
            Console.WriteLine("Gép {0} --- Játékos {1}", lehetoseg[gep], lehetoseg[ember]);
            switch (GepNyer(gep, ember))
            {
                case 0:
                    Console.WriteLine("Döntetelen");
                    break;
                case 1:
                    Console.WriteLine("Skynet nyert");
                    break;
                case 2:
                    Console.WriteLine("Játékos nyert");
                    break;
            }
        }
        static int GepNyer(int gep, int ember)
        {
            if (ember == 0 && gep == 1 //Gép nyer
                ||
                (ember == 1 && gep == 2)
                ||
                (ember == 2 && gep == 0)
                )
                
            {
                botnyer++;
                return 1;
            }
            else if (gep == ember) //Döntetlen
            {
                
                return 0;
            }
            else //Játékos nyer
            {
                jatekosnyer++;
                return 2;
            }
        }
        static int jatekos_valaszt()
        {
            Console.WriteLine("Kő {0}, Papír {1}, Olló {2}");
            Console.Write("Válasz: ");
            return Convert.ToInt32(Console.ReadLine());
        }
        static int gepvalasztas()
        {
            Random vel = new Random();
            return vel.Next(0, 3);
        }
        private static bool AkarJatszani()
        {
            Console.WriteLine("--------------------");
            

            Console.Write("Tovább? [i/n]: ");
            string valasz= Console.ReadLine().ToLower();
            Console.WriteLine("\n--------------------");
            if (valasz == "i")
	        {
                return true;
	        }
            else
	        {
             return false;
	        }
        }
        private static void Statisztikakiiras()
        {
            Console.WriteLine("\t Menetek száma: {0}\n\t Játékos nyert: {1}\n\t Gép nyert: {2}",menet,jatekosnyer,botnyer);
        }
        private static void statisztikafajlbol()
        {
            StreamReader stat = new StreamReader("statisztika.txt");
            int[] adat = new int[3];

            while (!stat.EndOfStream)
            {
                
                string[] sor = stat.ReadLine().Split(';');
               /* adat[0] = int.Parse(sor[0]);
                adat[1] = int.Parse(sor[1]);
                adat[2] = int.Parse(sor[2]);*/
                for (int i = 0; i < adat.Length; i++)
			{
                    adat[i] = int.Parse(sor[i]);
			}
             
                Console.WriteLine("{0} {1} {2}", adat[0],adat[1],adat[2]);
            }
            stat.Close();
                
            
            
            Console.WriteLine("------------- Statisztika vége -------------");
        }

        static void Main(string[] args)
        {
            statisztikafajlbol();

            bool tovabb = true;
           
            while (tovabb)
	    {
            menet++;
	        int jatekosvalaszt = jatekos_valaszt();
            int gep_valaszt = gepvalasztas();
            eredmeny_kiiras(gep_valaszt, jatekosvalaszt); 
            tovabb = AkarJatszani();

	    }
            Statisztikakiiras();
            Console.ReadKey();
        }

        
    }
}