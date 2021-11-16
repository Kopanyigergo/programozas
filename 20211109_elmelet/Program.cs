using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace _20211109_elmelet
{
    class Program
    {
        static void Main(string[] args)
        {
            //bitek();
            //novekvo();
            //nemek();
            //feladat1();
            //feladat2();
            //feladat3();
            //feladat4();
            //feladat5();
            //feladat6();
            //feladat7();
            //feladat8();
            //feladat9();
            //feladat10();

            Console.WriteLine("enter");
            Console.ReadLine();
        }
        static void bitek()
        {
            // gyors módszer
            string[] beolvas = File.ReadAllLines("1_bitek.txt");
            Console.WriteLine("A beolvasott bitek száma: {0}",beolvas.Length);
            int[] bit = new int[beolvas.Length];
            for (int i = 0; i < bit.Length; i++)
            {
                bit[i] = int.Parse(beolvas[i]);
            }
            Console.WriteLine();
        }
        static void novekvo()
        {
            string egysor = File.ReadAllText("3_novekvo.txt");
            Console.WriteLine(egysor);
            // szóköz mentén (karakter) felbontjuk
            //sok kicsi szöveget kapunk --> string típusú tömbbe
            string[] darabok = egysor.Split(' ');
            int[] szamok = new int[darabok.Length];
            for (int i = 0; i < szamok.Length; i++)
            {
                szamok[i] = int.Parse(darabok[i]);
            }
            Console.WriteLine(szamok.Sum());
            Console.WriteLine(szamok.Max());
            Console.WriteLine(szamok.Min());
            Console.WriteLine(szamok.Average());

            Console.WriteLine();
        }
        static void nemek()
        {
            string[] nemek = File.ReadAllLines("2_nemek.txt");
            Console.WriteLine("A beolvasott nemek száma: {0}",nemek.Length);
            

            Console.WriteLine();
        }
        static void feladat1()
        {
            //adatok_100_adat_szám
            string adat = File.ReadAllText("adatok_100_adat_szám.txt");
            Console.WriteLine(adat);
            string[] darabok = adat.Split(' ');
            int[] szamok = new int[darabok.Length];
            for (int i = 0; i < szamok.Length; i++)
            {
                szamok[i] = int.Parse(darabok[i]);
            }

            Console.WriteLine();
        }
        static void feladat2()
        {
            //első_szöveget tartalmaz
            string szöveg = File.ReadAllText("első_szöveget tartalmaz.txt", Encoding.Default);
            Console.WriteLine(szöveg);
            string[] darabok = szöveg.Split(' ');


            Console.WriteLine();
        }
        static void feladat3()
        {
            //harmadik_szöveget tartalmaz
            string szoveg = File.ReadAllText("harmadik_szöveget tartalmaz.txt",Encoding.Default);
            Console.WriteLine(szoveg);
            string[] darabok = szoveg.Split(' ');


            Console.WriteLine();
        }
        static void feladat4()
        {
            //hosszú1_e_mentén
            string menten = File.ReadAllText("hosszú1_e_mentén.txt",Encoding.Default);
            Console.WriteLine(menten);
            string[] darabok = menten.Split('e');
            foreach (var item in darabok)
            {
                Console.WriteLine(item);
            }


            Console.WriteLine();
        }
        static void feladat5()
        {
            //hosszú2_n_mentén
            string menten = File.ReadAllText("hosszú2_n_mentén.txt",Encoding.Default);
            Console.WriteLine(menten);
            string[] darabok = menten.Split('n');
            foreach (var item in darabok)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine();
        }
        static void feladat6()
        {
            //hosszú3_e_mentén
            string menten = File.ReadAllText("hosszú3_e_mentén.txt",Encoding.Default);
            Console.WriteLine(menten);
            string[] darabok = menten.Split('e');
            foreach (var item in darabok)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine();
        }
        static void feladat7()
        {
            //hosszú4_l_mentén
            string menten = File.ReadAllText("hosszú4_l_mentén.txt",Encoding.Default);
            Console.WriteLine(menten);
            string[] darabok = menten.Split('l');
            foreach (var item in darabok)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine();
        }
        static void feladat8()
        {
            //hosszú5_a_mentén
            string menten = File.ReadAllText("hosszú5_a_mentén.txt",Encoding.Default);
            Console.WriteLine(menten);
            string[] darabok = menten.Split('a');
            foreach (var item in darabok)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine();
        }
        static void feladat9()
        {
            //második_szöveget tartalmaz
            string szoveg = File.ReadAllText("második_szöveget tartalmaz.txt",Encoding.Default);
            Console.WriteLine(szoveg);
            string[] darabok = szoveg.Split(' ');

            Console.WriteLine();
        }
        static void feladat10()
        {
            //számok2
            string szamok = File.ReadAllText("számok2.txt");
            Console.WriteLine(szamok);
            string[] darabok = szamok.Split(' ');
            int[] szamokok = new int[darabok.Length];
            for (int i = 0; i < szamokok.Length; i++)
            {
                szamokok[i] = int.Parse(darabok[i]);
            }

            Console.WriteLine();
        }
    }
}
