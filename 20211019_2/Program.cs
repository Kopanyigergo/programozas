using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20211019_2
{
    class Program
    {
        static void Main(string[] args)
        {
            //feladat1();
            //feladat2();
            //feladat3();
            //feladat4();
            //feladat5();

            Console.WriteLine();
            Console.ReadLine();
        }
        static void feladat1()
        {
            Console.WriteLine("kérem a téglatest a oldalát! a=");
            double a = double.Parse(Console.ReadLine());
            Console.WriteLine("kérem a téglatest a oldalát! b=");
            double b = double.Parse(Console.ReadLine());
            Console.WriteLine("kérem a téglatest a oldalát! c=");
            double c = double.Parse(Console.ReadLine());
            Console.WriteLine("a téglatset térfogata {0} cm3, felszíne {1}", a * b * c, 2 * (a * b + a * c + b * c));
        }
        static void feladat2()
        {
            Console.WriteLine("kérek egy számot 1 és 7 között! szám=");
            int szam = int.Parse(Console.ReadLine());
            switch (szam)
            {
                case 1:
                    Console.WriteLine("hétfő");
                    break;
                case 2:
                    Console.WriteLine("kedd");
                    break;
                case 3:
                    Console.WriteLine("szerda");
                    break;
                case 4:
                    Console.WriteLine("csütörtök");
                    break;
                case 5:
                    Console.WriteLine("péntek");
                    break;
                case 6:
                    Console.WriteLine("szombat");
                    break;
                case 7:
                    Console.WriteLine("vasárnap");
                    break;

                default:
                    Console.WriteLine("nem jó értéket adtál!");
                    break;
            }
        }
        static void feladat3()
        {
            Console.WriteLine("kérek egy számot! szám=");
            double szam = double.Parse(Console.ReadLine());
            if (szam > -50 && szam < 70)
            {
                Console.WriteLine("benne van.");
            }
            else
            {
                Console.WriteLine("nincs benne");
            }
        }
        static void feladat4()
        {
            for (int i = 120; i > 40; i = i - 15)
            {
                Console.Write("{0} ", i);
            }
        }
        static void feladat5()
        {
            for (int i = 1; i < 41; i++)
            {
                if (i * 9 % 7 == 0)
                {
                    Console.Write("{0} ",i*9);
                }
            }
            Console.WriteLine();
            int cv = 1;
            while (cv < 41)
            {
                if (cv * 9 % 7 == 0)
                {
                    Console.Write("{0} ",cv*9);
                }
                cv++;
            }
        }
    }
}
