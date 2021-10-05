using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20211005_2
{
    class Program
    {
        static void Main(string[] args)
        {
            //készenvan: 1,2,3,6,7,8
            //feladat1();
            //feladat2();
            //feladat3();
            //feladat4();
            //feladat5();
            //feladat6();
            //feladat7();
            //feladat8();
            feladat9();
            //feladat10();
        }
        static void feladat1()
        {
            for (int i = 1; i < 21; i++)
            {
                Console.Write("{0} ", i);
            }
            for (int i = 1; i < 21; i++)
            {
                Console.WriteLine("{0}",i);
            }
            Console.WriteLine("while ciklussal");
            int cv = 1;
            while (cv < 21)
            {
                Console.Write("{0} ",cv);
                cv++;
            }
            int cv2 = 1;
            while (cv2<21)
            {
                Console.WriteLine("{0}",cv2);
                cv2++;
            }

        }
        static void feladat2()
        {
            for (int i = 15; i < 93; i++)
            {
                Console.Write("{0} ",i);
            }
            Console.WriteLine("while ciklussal");
            int cv = 15;
            while (cv<93)
            {
                Console.Write("{0} ",cv);
                cv++;
            }
        }
        static void feladat3()
        {
            for (int i = 1; i < 31; i++)
            {
                if (i %2 ==0)
                {
                    Console.Write("{0} ",i);
                }
            }
            for (int i = 1; i < 31; i++)
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine("{0} ", i);
                }
            }
            Console.WriteLine("while ciklussal");
            int cv = 1;
            while (cv<31)
            {
                if (cv % 2==0)
                {
                    Console.Write("{0} ",cv);
                }
                cv++;
            }
            int cv2 = 1;
            while (cv2 < 31)
            {
                if (cv2 % 2 == 0)
                {
                    Console.WriteLine("{0} ", cv2);
                }
                cv2++;
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
            for (int i = 1; i < 16; i++)
            {
                Console.WriteLine("{0} ", Math.Pow(i,2));
            }
            Console.WriteLine("while ciklussal");
            int cv = 1;
            while (cv<16)
            {
                Console.WriteLine("{0} ",Math.Pow(cv,2));
                cv++;
            }
        }
        static void feladat7()
        {
            for (int i = 100; i < 401; i++)
            {
                if (i % 4 == 0)
                {
                    Console.WriteLine("{0} ",i);
                }
            }
            Console.WriteLine("while ciklussal");
            int cv = 100;
            while (cv<401)
            {
                if (cv % 4 == 0)
                {
                    Console.WriteLine("{0} ",cv);
                    cv++;
                }
            }
        }
        static void feladat8()
        {
            for (int i = 30; i < 101; i=i+9)
            {
                Console.WriteLine("{0}",i);
            }
            Console.WriteLine("while ciklussal");
            int cv = 30;
            while (cv < 101)
            {
                Console.WriteLine("{0}",cv);
                cv = cv + 9;
            }
        }
        static void feladat9()
        {
            for (int i = 150; i > 40; i=i+12)
            {
                Console.WriteLine("{0} ",i);
            }
        }
        static void feladat10()
        {
        }
    }
}
