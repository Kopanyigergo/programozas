using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20210914
{
    class Program
    {
        static void Main(string[] args)
        {
            //feladat1();
            //feladat2();
            feladat3();
            //feladat4();
            //feladat5();
            //feladat6();
            //feladat7();
            //feladat8();
            //feladat9();
            //feladat10();
            //feladat11();

            Console.Write("Nyomj meg egy billentyűt!");
            Console.ReadKey();
        }

        static void feladat1()
            {
            Console.WriteLine("Kérek egy számot: ");
            int szam =int.Parse(Console.ReadLine());
            if (szam % 2)
	            {
                Console.WriteLine("páros");
	            }
            else
	{
             Console.WriteLine("páratlan");
	}
            }

        static void feladat2()
            {
            }

        static void feladat3()
            {
            Console.Write("Kérek egy egész számot 10 és 50 között: ");
            int szam = int.Parse(Console.ReadLine());
            if ( szam > 0)
                {
                Console.WriteLine("nincs fagy");
                }
            else
	{
             Console.WriteLine("fagy van");
	}
            }

        static void feladat4()
            {
            }

        static void feladat5()
            {
            }

        static void feladat6()
        {
            Console.Write("Kérek egy egész számot 10 és 50 között: ");
            int szam = int.Parse(Console.ReadLine());
            if (szam < 10 || szam > 50)
            {
                Console.WriteLine("Nem megfelelő a szám!");
            }
            else
            {
                int hanyados = szam / 10;
                if (hanyados == 1)
                {
                    Console.WriteLine("tízesek");
                }
                else if (hanyados == 2)
                {
                    Console.WriteLine("húszasok");
                }
                else if (hanyados == 3)
                {
                    Console.WriteLine("harmincasok");
                }
                else if (hanyados == 4)
                {
                    Console.WriteLine("negyvenesek");
                }
                else
                {
                    Console.WriteLine("ötven");
                }
            }
        }

        static void feladat7()
            {
            }

        static void feladat8()
            {
            }

        static void feladat9()
            {
            Console.Write("Kérek egy egész számot: ");
            int a = Convert.ToInt32(Console.ReadLine());
            bool oszthato = false;
            if (a % 3 == 0)
            {
                Console.WriteLine("3-vel osztható");
                oszthato = true;
            }
            if (a % 4 == 0)
            {
                Console.WriteLine("4-mal osztható");
                oszthato = true;
            }
            if (a % 9 == 0)
            {
                Console.WriteLine("9-tel osztható");
                oszthato = true;
            }
            if (!oszthato)
            {
                Console.WriteLine("nem osztható 3-al, 4-el, 9-el");
            }
            }

        static void feladat10()
            {
            }

        static void feladat11()
            {
            }
    }
}
