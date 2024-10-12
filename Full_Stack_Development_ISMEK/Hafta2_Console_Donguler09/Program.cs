using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hafta2_Console_Donguler09
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //girilen 10 sayıdan 3 basamaklıların adedini diğer sayılarında toplamını bulan program

            int adet = 0;
            int toplam = 0;

            for (int i = 1; i <= 10; i++)
            {
                Console.Write(i + ". sayıyı giriniz: ");
                int sayi = Convert.ToInt32(Console.ReadLine());
                if (sayi >= 100 && sayi <= 999)
                {
                    adet++;
                }
                else
                {
                    toplam += sayi;
                }
            }
            Console.WriteLine();
            Console.WriteLine("3 basamaklı sayıların adedi: " + adet);
            Console.WriteLine("3 basamaklı sayılar hariç diğer sayıların toplamı: " + toplam);

            Console.Read();
        }
    }
}
