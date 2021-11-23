using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace _20211123
{
    class Program
    {
        static string[] kozmondasok;
        static void Main(string[] args)
        {
            feladat1();
            feladat2();
            feladat3();
            feladat4();
            feladat5();
            feladat6();
            feladat8();
            feladat9();
            feladat10();

            Console.WriteLine("enter");
            Console.ReadLine();
        }
        static void feladat1()
        {
            string[] beolvas = File.ReadAllLines("kozmondasok.txt",Encoding.Default);
            kozmondasok = beolvas;
            
        }
        static void feladat2()
        {
            Console.WriteLine("2. feladat: A közmondások száma {0}.",kozmondasok.Length);
        }
        static void feladat3()
        {
            Console.WriteLine("3. feladat");
            for (int i = 0; i < kozmondasok.Length; i++)
            {
                if (kozmondasok[i].ToLower().Contains("malacz"))
                {
                    Console.WriteLine("\t{0}", kozmondasok[i]);
                }
            }
        }
        static void feladat4()
        {
            int db = 0;
            for (int i = 0; i < kozmondasok.Length; i++)
            {
                if (kozmondasok[i].ToLower().Contains("ló"))
                {
                    db++;
                }
            }
            Console.WriteLine("4. feladat: {0} közmondásban szerepel a ló szó.",db);
        }
        static void feladat5()
        {
            int maxindex = 0;
            for (int i = 0; i < kozmondasok.Length; i++)
            {
                if (kozmondasok[i].Length>kozmondasok[maxindex].Length)
                {
                    maxindex = i;
                }
            }
            Console.WriteLine("5. feladat: A leghosszabb közmondás {0} karakterből áll.",kozmondasok[maxindex].Length);
            Console.WriteLine("\t{0}",kozmondasok[maxindex]);
            Console.WriteLine("7.feladat: ");
            string[] szavak = kozmondasok[maxindex].Split(' ');
            Console.WriteLine("\tA leghosszabb közmondás második szava: {0}",szavak[1]);
        }
        static void feladat6()
        {
            int minindex = 0;
            for (int i = 0; i < kozmondasok.Length; i++)
            {
                if (kozmondasok[i].Length<kozmondasok[minindex].Length)
                {
                    minindex = i;
                }
            }
            Console.WriteLine("6. feladat: A legrövidebb közmondás {0} karakterből áll",kozmondasok[minindex].Length);
            Console.WriteLine("\t{0}",kozmondasok[minindex]);
        }
        static void feladat8()
        {
            int maxindex = 0;
            for (int i = 0; i < kozmondasok.Length; i++)
            {
                if (kozmondasok[i].Split(' ').Length > kozmondasok[maxindex].Split(' ').Length)
                {
                    maxindex = i;
                }
            }
            Console.WriteLine("8. feladat: A legtöbb szóból álló közmondás:");
            Console.WriteLine("\t{0}",kozmondasok[maxindex]);
        }
        static void feladat9()
        {
            string minden = File.ReadAllText("kozmondasok.txt",Encoding.Default).ToLower();
            int db = 0;
            for (int i = 0; i < minden.Length; i++)
            {
                if (minden[i]=='ű')
                {
                    db++;
                }
            }
            Console.WriteLine("9. feladat: Az ű betűk száma: {0}",db);
        }
        static void feladat10()
        {
            bool vanbenne = false;
            for (int i = 0; i < kozmondasok.Length; i++)
            {
                if (kozmondasok[i].Contains("krajczár") && kozmondasok[i].Contains("forint"))
                {
                    vanbenne = true;
                }
            }
            if (vanbenne)
            {
                Console.WriteLine("10. feladat: Van olyan közmondás amely tartalmazza a krajczár és forint szavakat is.");
            }
            else
            {
                Console.WriteLine("10. feladat: Nincs olyan közmondás amely tartalmazza a krajczár és forint szavakat is.");
            }
        }

    }
}
