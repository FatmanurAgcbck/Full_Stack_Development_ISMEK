using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hafta2_Console_Donguler06
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //dışarıdan girilen 10 sayıdan çift sayıların adedini  teklerinde çarpımını bulan program

            int adet = 0;
            int carpim = 1;


            for (int i = 1; i <= 10; i++)
            {

                Console.Write(i + ". sayıyı Giriniz: ");
                int sayi = Convert.ToInt32(Console.ReadLine());
                if (sayi % 2 == 0)
                {
                    adet++;
                }
                else
                {
                    carpim = carpim * sayi; //carpim *= sayi;
                }

            }
            Console.WriteLine("--------------------------------------");
            Console.WriteLine("Tek Sayıların Çarpımı: " + carpim);
            Console.WriteLine("Çift Sayıların Adedi: " + adet);

            Console.Read();
        }
    }
}
