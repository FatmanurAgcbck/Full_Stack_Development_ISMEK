using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hafta2_Console_Donguler04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //dışarıdan girilen 5 sayının toplamı

            int toplam = 0;
            float ortalama = 0;
            float sayac = 0;

            for (int i = 1; i <= 5; i++)
            {
                sayac++;
                Console.Write(i + ". Sayıyı Giriniz: ");
                int sayi = Convert.ToInt32(Console.ReadLine());
                toplam += sayi;

            }

            Console.WriteLine("Toplam Değer: " + toplam);
            ortalama = toplam / sayac;
            Console.WriteLine("Ortalama: " + ortalama);

            Console.Read();
        }
    }
}
