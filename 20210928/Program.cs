using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20210928
{
    class Program
    {
        static void Main(string[] args)
        {
            //feladat1();
            //feladat3();
            //feladat4();
            feladat5();
            //feladat6();
            //feladat9();
            //feladat12();
            //feladat13();
            //feladat14();
            //feladat15();
            //feladat16();
        }
        static void feladat1()
        {
            Console.WriteLine("kérek egy számot");
            int szam = int.Parse(Console.ReadLine());
            if (szam % 2 == 0)
            {
                Console.WriteLine("páros");
            }
            else
            {
                Console.WriteLine("páratlan");
            }
            
            Console.WriteLine("enter");
            Console.ReadLine();
        }
        static void feladat3()
        {
            Console.WriteLine("kérek egy számot");
            int fagye = int.Parse(Console.ReadLine());
            if (fagye < 0)
            {
                Console.WriteLine("fagy van");
            }
            else
            {
                Console.WriteLine("nincs fagy");
            }

            Console.WriteLine("enter");
            Console.ReadLine();
        }
        static void feladat4()
        {
            Console.WriteLine("kérek egy számot");
            int szam = int.Parse(Console.ReadLine());
            if (szam < -30 || szam > 40)
            {
                Console.WriteLine("a szám nincs -30 és 40 között");
            }
            else
            {
                Console.WriteLine("a szám -30 és 40 között van");
            }

            Console.WriteLine("enter");
            Console.ReadLine();
        }
        static void feladat5()
        {
            Console.WriteLine("kérek egy számot");
            int szam = int.Parse(Console.ReadLine());
            if (szam < 16)
            {

            }
            else
            {

            }

            Console.WriteLine("enter");
            Console.ReadLine();
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
        static void feladat9()
        {
            Console.Write("Kérek egy egész számot: ");
            int szam = Convert.ToInt32(Console.ReadLine());
            bool oszthato = false;
            if (szam % 3 == 0)
            {
                Console.WriteLine("3-vel osztható");
                oszthato = true;
            }
            if (szam % 4 == 0)
            {
                Console.WriteLine("4-mal osztható");
                oszthato = true;
            }
            if (szam % 9 == 0)
            {
                Console.WriteLine("9-tel osztható");
                oszthato = true;
            }
            if (!oszthato)
            {
                Console.WriteLine("nem osztható 3-al, 4-el, 9-el");
            }
        }
        static void feladat12()
        {
            Console.WriteLine("kérek egy számot 1-12 között");
            int honap = int.Parse(Console.ReadLine());

            if (honap < 1 || honap > 12)
            {
                Console.WriteLine("nem jó a szám");
            }
            else
            {
                switch (honap)
                {
                    case 1:
                        Console.WriteLine("január");
                        break;
                    case 2:
                        Console.WriteLine("február");
                        break;
                    case 3:
                        Console.WriteLine("március");
                        break;
                    case 4:
                        Console.WriteLine("április");
                        break;
                    case 5:
                        Console.WriteLine("május");
                        break;
                    case 6:
                        Console.WriteLine("június");
                        break;
                    case 7:
                        Console.WriteLine("július");
                        break;
                    case 8:
                        Console.WriteLine("augusztus");
                        break;
                    case 9:
                        Console.WriteLine("szeptember");
                        break;
                    case 10:
                        Console.WriteLine("október");
                        break;
                    case 11:
                        Console.WriteLine("november");
                        break;
                    case 12:
                        Console.WriteLine("december");
                        break;


                    default:
                        break;
                }
            }
            Console.WriteLine("enter");
            Console.ReadLine();
        }
        static void feladat13()
        {
            Console.WriteLine("kérek egy számot 1-12 között");
            int evszak = int.Parse(Console.ReadLine());

            if (evszak < 1 || evszak > 12)
            {
                Console.WriteLine("nem jó a szám");
            }
            else
            {
                switch (evszak)
                {
                    case 1:
                        Console.WriteLine("tél");
                        break;
                    case 2:
                        Console.WriteLine("tél");
                        break;
                    case 3:
                        Console.WriteLine("tavasz");
                        break;
                    case 4:
                        Console.WriteLine("tavasz");
                        break;
                    case 5:
                        Console.WriteLine("tavasz");
                        break;
                    case 6:
                        Console.WriteLine("nyár");
                        break;
                    case 7:
                        Console.WriteLine("nyár");
                        break;
                    case 8:
                        Console.WriteLine("nyár");
                        break;
                    case 9:
                        Console.WriteLine("ősz");
                        break;
                    case 10:
                        Console.WriteLine("ősz");
                        break;
                    case 11:
                        Console.WriteLine("ősz");
                        break;
                    case 12:
                        Console.WriteLine("tél");
                        break;


                    default:
                        break;
                }
            }
            Console.WriteLine("enter");
            Console.ReadLine();
        }
        static void feladat14()
        {
            Console.WriteLine("kérek egy számot (max 2 milliárd!)");
            long nagyszam = long.Parse(Console.ReadLine());
            if (nagyszam < 1 || nagyszam > 2000000000)
            {
                Console.WriteLine("túl nagy a szám");
            }
            else
            {
                switch (nagyszam)
                {
                    

                    default:
                        break;
                }
            }


            Console.WriteLine("enter");
            Console.ReadLine();
        }
        static void feladat15()
        {
        }
        static void feladat16()
        {
            Console.WriteLine("kérek egy számot 1-5 között");
            int jegy = int.Parse(Console.ReadLine());
            if (jegy < 1 || jegy > 5)
            {
                Console.WriteLine("nem jó a szám");
            }
            else
            {
                switch (jegy)
                {
                    case 1:
                        Console.WriteLine("elégtelen");
                        break;
                    case 2:
                        Console.WriteLine("elégséges");
                        break;
                    case 3:
                        Console.WriteLine("közepes");
                        break;
                    case 4:
                        Console.WriteLine("jó");
                        break;
                    case 5:
                        Console.WriteLine("jeles");
                        break;

                    default:
                        break;
                }
            }

            Console.WriteLine("enter");
            Console.ReadLine();
        }
    }
}
