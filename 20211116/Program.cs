using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace _20211116
{
    class Program
    {
        static void Main(string[] args)
        {
            //feladat1();
            //feladat2();
            //feladat3();
            feladat4();
        }
        static void feladat1()
        {
            //gyumolcsok.txt
            string[] beolvas = File.ReadAllLines("gyumolcsok.txt",Encoding.Default);
            int sorokszama = beolvas.Length;
            int oszlopszam = beolvas[0].Split('\t').Length;
            string[,] szavak = new string[sorokszama, oszlopszam];
            for (int i = 0; i < sorokszama; i++)
            {
                string[] darabok = beolvas[i].Split('\t');
                for (int j = 0; j < oszlopszam; j++)
                {
                    szavak[i ,  j] = darabok[j];
                }
            }
            Console.WriteLine("Elemek száma: {0}",szavak.Length);
            Console.WriteLine("Sorok száma: {0}",szavak.GetLength(0));
            Console.WriteLine("Oszlopok száma: {0}",szavak.GetLength(1));

            Console.WriteLine("enter");
            Console.ReadLine();
        }
        static void feladat2()
        {
            //sportok.txt
            string[] beolvas = File.ReadAllLines("sportok.txt",Encoding.Default);
            int sorokszama = beolvas.Length;
            int oszlopszam = beolvas[0].Split(';').Length;
            string[,] szavak = new string[sorokszama, oszlopszam];
            for (int i = 0; i < sorokszama; i++)
            {
                string[] darabok = beolvas[i].Split(';');
                for (int j = 0; j < oszlopszam; j++)
                {
                    szavak[i, j] = darabok[j];
                }
            }
            Console.WriteLine("Elemek száma: {0}",szavak.Length);
            Console.WriteLine("Sorok száma: {0}",szavak.GetLength(0));
            Console.WriteLine("Oszlopok száma: {0}",szavak.GetLength(1));

            Console.WriteLine("enter");
            Console.ReadLine();
        }
        static void feladat3()
        {
            //számok3.txt
            string[] beolvas = File.ReadAllLines("számok3.txt");
            int sorokszama = beolvas.Length;
            int oszlopszam = beolvas[0].Split(' ').Length;
            string[,] szamokok = new string[sorokszama, oszlopszam];
            for (int i = 0; i < sorokszama; i++)
            {
                string[] darabok = beolvas[i].Split(' ');
                for (int j = 0; j < oszlopszam; j++)
                {
                    szamokok[i , j] = darabok[j];
                }
            }
            Console.WriteLine("Elemek száma: {0}",szamokok.Length);
            Console.WriteLine("Sorok száma: {0}", szamokok.GetLength(0));
            Console.WriteLine("Oszlopok száma: {0}", szamokok.GetLength(1));

            Console.WriteLine("enter");
            Console.ReadLine();
        }
        static void feladat4()
        {
            //varos.txt
            string[] beolvas = File.ReadAllLines("varos.txt");
            int sorokszama = beolvas.Length;
            int oszlopszam = beolvas[0].Split(' ').Length;
            string[,] szamokok = new string[sorokszama, oszlopszam];
            for (int i = 0; i < sorokszama; i++)
            {
                string[] darabok = beolvas[i].Split(' ');
                for (int j = 0; j < oszlopszam; j++)
                {
                    szamokok[i, j] = darabok[j];
                }
            }
            Console.WriteLine("Elemek száma: {0}", szamokok.Length);
            Console.WriteLine("Sorok száma: {0}", szamokok.GetLength(0));
            Console.WriteLine("Oszlopok száma: {0}", szamokok.GetLength(1));

            Console.WriteLine("enter");
            Console.ReadLine();
        }
    }
}
