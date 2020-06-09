using System;
using System.ComponentModel;
using System.IO;
using System.Net.Http.Headers;
using struct_ceh;

namespace ConsoleApp1
{
    class Program
    {
        static Ceh[] ReadData(string fileName)
        {
            string path = "C:\\Users\\dimaz\\Desktop\\";
            string newPath = path.Insert(path.Length, fileName);
            int cnt = System.IO.File.ReadAllLines(newPath).Length;
            Ceh[] works = new Ceh[cnt];
            var stream = File.Open(newPath, FileMode.Open, FileAccess.Read);
            StreamReader sr = new StreamReader(stream, System.Text.Encoding.Default);

            for (int i = 0; i < cnt; i++)
            {
                var str = sr.ReadLine();
                Ceh work = new Ceh(str);
                works[i] = work;
            }
            return works;
        }

        static void kilkist(Ceh[] wrk, string worker1)
        {
            
            for (int j = 0; j < wrk.Length; j++)
            {
                if (wrk[j].workerName == worker1)
                {
                    int aA = Convert.ToInt32(wrk[j].amountA);
                    int aB = Convert.ToInt32(wrk[j].amountB);
                    int aC = Convert.ToInt32(wrk[j].amountC);
                    int total = aA + aB + aC;
                    Console.WriteLine("Zahalna k-st vyrobiv = " + total);
                }
            }
        }

        static void second( Ceh[] wrk, string ch)
        {
            int sal = 0;
            int wrkrsCount = 0;
            for (int k = 0; k < wrk.Length; k++)
            {
                if(ch == wrk[k].cehName)
                {
                    int priceWA = Convert.ToInt32(wrk[k].amountA) * Convert.ToInt32(wrk[k].priceA);
                    int priceWB = Convert.ToInt32(wrk[k].amountB) * Convert.ToInt32(wrk[k].priceB);
                    int priceWC = Convert.ToInt32(wrk[k].amountC) * Convert.ToInt32(wrk[k].priceC);
                    sal += priceWA + priceWB + priceWC;
                    wrkrsCount++;
                }
            }
            Console.WriteLine("Zarplata = " + sal);
            Console.WriteLine("Serednya zarplata = " + sal/wrkrsCount );
        }
        static void Main(string[] args)
        {
            Ceh[] wrk = ReadData("data.txt");
            Console.WriteLine("1 - Zahalna k-st vyrobiv");
            Console.WriteLine("2 - Zarplata ta serednya");
            int numb = Convert.ToInt32(Console.ReadLine());

            switch(numb)
            {
                case 1:
                    Console.WriteLine("Vvedit prizvysche ta inicialy vyrobnyka");
                    string worker1 = Convert.ToString(Console.ReadLine());
                    kilkist(wrk, worker1);
                    break;
                case 2:
                    Console.WriteLine("vvedit Ceh");
                    string ch = Convert.ToString(Console.ReadLine());
                    second(wrk, ch);
                    break;
            }            
            Console.ReadKey();
        }
    }
}
