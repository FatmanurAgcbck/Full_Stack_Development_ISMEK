using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hafta4_Console_Array04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //random atanan 7 sayının son rakamları 0 olanların toplamını bulam program

            //int toplam = 0;
            //Random rnd = new Random();

            //for (int i = 1; i <=7; i++)
            //{
            //    int sayi = rnd.Next(100,301);

            //    if (sayi % 10 == 0)
            //    {
            //        toplam += sayi;
            //    }

            //    Console.WriteLine("Sayılar: " + sayi);
            //}

            //Console.WriteLine("Son Rakamı 0 Olan Sayıların Toplamı: " + toplam);


            int[] sayilar = new int[7];
            int toplam = 0;

            Random rastgele = new Random();

            for (int i = 0; i < 7; i++)
            {

                int sayi = rastgele.Next(100,301);
                sayilar[i] = sayi;

                if (sayilar[i] % 10 == 0)
                {
                    toplam += sayilar[i];
                }
                Console.WriteLine((i+1)+". Sayı: " + sayilar[i]);
            }
            Console.WriteLine("Son Rakamı 0 Olan Sayıların Toplamı: " + toplam);

            Console.Read();
        }
    }
}
