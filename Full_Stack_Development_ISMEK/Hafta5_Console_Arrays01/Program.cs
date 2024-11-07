using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hafta5_Console_Arrays01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //kullanıcı dizi belirlesin ve eleman sayısını da kullanıcı belirlesinn. kullanıcı sayılar girsin en büyük en küçük sayıyı yazdıran program

            Console.Write("Kaç adet sayı girmek istiyorsun? ");
            int n = Convert.ToInt32(Console.ReadLine());

            int[] sayilar = new int[n];

            for (int i = 0; i < n; i++)
            {
                Console.Write($"{i+1}. Sayıyı giriniz: ");
                sayilar[i] = Convert.ToInt32(Console.ReadLine());
               
            }

            int enBuyuk = sayilar[0]; //dizideki ilk eleman en büyük değişkenin içine at
            int enKucuk = sayilar[0];


            for (int i = 0;i < n; i++)
            {
                if (sayilar[i] > enBuyuk)  //girilen değerlerin kontrolünü sağlıyor hangisi büyük diye kontrol edip enBuyuk değişkenine atar
                {
                    enBuyuk = sayilar[i];
                    
                }
                if (sayilar[i] < enKucuk)
                {
                    enKucuk = sayilar[i];
                    
                }
            }
            Console.WriteLine();
            Console.WriteLine("En Büyük Sayı:  " + enBuyuk);
            Console.WriteLine("En Küçük Sayı:  " + enKucuk);


            Console.Read();
        }
    }
}
