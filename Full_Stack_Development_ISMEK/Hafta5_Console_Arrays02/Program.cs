using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hafta5_Console_Arrays02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //girilen sayılar çift tek diye ayıran program 

            Console.Write("Kaç adet sayı girmek istiyorsunuz? ");
            int n = Convert.ToInt32(Console.ReadLine());

            int[] sayilar = new int[n];
            int[] tekSayilar = new int[n];
            int[] ciftSayilar = new int[n];

            int tekSayi = 0;
            int ciftSayi = 0;

            for (int i = 0; i < n; i++)
            {
                Console.Write($"{i + 1}. Sayıyı girin: ");
                sayilar[i] = Convert.ToInt32(Console.ReadLine());

                if (sayilar[i] % 2 == 0)
                {
                    ciftSayilar[ciftSayi] = sayilar[i];
                    ciftSayi++;
                }
                else
                {
                    tekSayilar[tekSayi] = sayilar[i];
                    tekSayi++;
                }
            }
            Console.WriteLine();

            for (int i = 0;i < ciftSayi; i++)
            {
                Console.WriteLine("Çift Sayılar: " + ciftSayilar[i] + " ");
                
            }
            Console.WriteLine();
            for(int i = 0;i<tekSayi; i++)
            {
                Console.WriteLine("Tek Sayılar: " + tekSayilar[i] + " ");
               
            }

            Console.WriteLine();

            Console.WriteLine(ciftSayi + " adet çift sayı var");
            Console.WriteLine(tekSayi + " adet tek sayı var");

            Console.Read();
        }
    }
}
