using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace _20211104
{
    class Program
    {
        static void Main(string[] args)
        {
            //feladat1();
            feladat2();
            feladat3();
        }
        static void feladat1()
        {
            //kiírjuk 1-10-ig a számokat a kicsik.txt-be
            FileStream fs = new FileStream("kicsik.txt", FileMode.OpenOrCreate);
            StreamWriter sw = new StreamWriter(fs);
            for (int i = 1; i < 11; i++)
            {
                sw.WriteLine(i);
            }

            sw.Close();
            fs.Close();
            List<string> kiir = new List<string>();
            for (int i = 1; i < 11; i++)
            {
                kiir.Add(i.ToString());
            }
            File.WriteAllLines("kicsik1.txt", kiir);
        }
        static void feladat2()
        {
            FileStream fs = new FileStream("negyzetek.txt", FileMode.OpenOrCreate);
            StreamWriter sw = new StreamWriter(fs);
            for (int i = 1; i < 16; i++)
            {
                sw.WriteLine(i*i);
            }

            sw.Close();
            fs.Close();
        }
        static void feladat3()
        {
            FileStream fs = new FileStream("harommal.txt", FileMode.OpenOrCreate);
            StreamWriter sw = new StreamWriter(fs);
            for (int i = 1; i < 101; i++)
            {
                if (i%3==0)
                {
                    sw.WriteLine(i);
                }
            }

            sw.Close();
            fs.Close();
        }
    }
}
