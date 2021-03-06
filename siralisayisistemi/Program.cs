using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace siralisayisistemi
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("kaç adet sayı üretelim? ");
            int sayi = int.Parse(Console.ReadLine());
            Console.Write("başlangıç değeri= ");
            int ilk = int.Parse(Console.ReadLine());
            Console.Write("son değeri= ");
            int son = int.Parse(Console.ReadLine());
            Random rnd = new Random();
            int[] sayilar = new int[sayi];
            for (int i = 0; i < sayilar.Length; i++)
            {
                sayilar[i] = rnd.Next(ilk, son);
                for (int k = 0; k < i; k++)
                {
                    if (sayilar[i] == sayilar[k])
                    {
                        i--;
                        break;
                    }

                }
            }
            Array.Sort(sayilar);
            for (int i = 0; i < sayilar.Length; i++)
            {
                Console.WriteLine($"-{sayilar[i]}");
            }
            Console.ReadKey();
        }
    }
}
