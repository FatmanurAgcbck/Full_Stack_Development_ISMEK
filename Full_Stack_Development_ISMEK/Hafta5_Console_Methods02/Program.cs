using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hafta5_Console_Methods02
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //metot kullanarak dizi ortalamasını bulan program


            Random rand = new Random();
            

            int[] sayilar = new int[10];

            for (int i = 0; i < sayilar.Length; i++)
            {
                sayilar[i] = rand.Next(0,100);
                Console.WriteLine("Sayı: " + sayilar[i]);
            }
            Console.WriteLine("Dizideki Sayıların Ortalaması = " + Ortalama(sayilar));

            Console.Read();
        }

        static double Ortalama(int[]sayilar)
        {
            int toplam = 0;  

            for (int i = 0; i < sayilar.Length; i++)
            {
                toplam += sayilar[i];
            }
            return (double)toplam / sayilar.Length;

        }
    }
}
