using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20211012
{
    class Program
    {
        static void Main(string[] args)
        {
            //kész: 11, 12, 13, 14, 15, 20

            //feladat11();
            //feladat12();
            //feladat13();
            //feladat14();
            feladat15();
            //feladat16();
            //feladat17();
            //feladat18();
            //feladat19();
            //feladat20();
        }
        static void feladat11()
        {
            for (int i = -30; i < 31; i=i+5)
            {
                Console.WriteLine("{0}",i);
            }
            Console.WriteLine("while ciklussal");
            int cv = -30;
            while (cv < 31)
            {
                Console.Write("{0} ",cv);
                cv = cv + 5;
            }
            Console.WriteLine();
        }
        static void feladat12()
        {
            for (int i = 3; i < 4; i++)
            {
                for (int j = 1; j < 18; j++)
                {
                    Console.Write("{0} ", i * j);
                }
            }
            Console.WriteLine();
            Console.WriteLine("while ciklussal");
            int cv = 3;
            while (cv < 4)
            {
                int cv1 = 1;
                while (cv1<18)
                {
                    Console.Write("{0} ",cv*cv1);
                    cv1++;
                }
                cv++;
            }
            Console.WriteLine();
        }
        static void feladat13()
        {
            for (int i = 2; i < 3; i++)
            {
                for (int j = 1; j < 17; j++)
                {
                    Console.Write("{0} ",i*j);
                }
            }
            Console.WriteLine();
            Console.WriteLine("while ciklussal");
            int cv = 2;
            while (cv<3)
            {
                int cv1 = 1;
                while (cv1<17)
                {
                    Console.Write("{0} ",cv*cv1);
                    cv1++;
                }
                cv++;
            }
            Console.WriteLine();
        }
        static void feladat14()
        {
            for (int i = 7; i < 8; i++)
            {
                for (int j = 1; j < 26; j++)
                {
                    if (7 * j % 4 == 0)
                    {
                        Console.Write("{0} ",j);
                    }
                }
            }
            Console.WriteLine();
            Console.WriteLine("while ciklussal");
            int cv = 7;
            while (cv<8)
            {
                int cv1 = 1;
                while (cv1<26)
                {
                    if (7 * cv1 % 4 == 0)
                    {
                        Console.Write("{0} ",cv1);
                    }
                    cv1++;
                }
                cv++;
            }
            Console.WriteLine();
        }
        static void feladat15()
        {
            for (int i = 1; i < 145; i++)
            {
                if (144 % i == 0)
                {
                    Console.Write("{0} ",i);
                }
            }
            Console.WriteLine();
            Console.WriteLine("while ciklussal");
            int cv = 1;
            while (cv < 145)
            {
                if (144 % cv == 0)
                {
                    Console.Write("{0} ",cv);
                }
                cv++;
            }
            Console.WriteLine();

        }
        static void feladat16()
        {
        }
        static void feladat17()
        {
        }
        static void feladat18()
        {
            
        }
        static void feladat19()
        {

        }
        static void feladat20()
        {
            for (int i = 8; i < 9; i++)
            {
                for (int j = 1; j < 11; j++)
                {
                    Console.Write("{0} ",i*j);
                }
            }
            Console.WriteLine();
            Console.WriteLine("while ciklussal");
            int cv = 8;
            while (cv<9)
            {
                int cv1 = 1;
                while (cv1<11)
                {
                    Console.Write("{0} ",cv*cv1);
                    cv1++;
                }
                cv++;
            }
            Console.WriteLine();
        }
    }
}
