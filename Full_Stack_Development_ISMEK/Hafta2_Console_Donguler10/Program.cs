using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hafta2_Console_Donguler10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //klavyeden girilen 10 sayının toplamına, girilen 5. sayıya bölümü 
            double sonuc = 0;
            double toplam = 0;
            double bolen = 0;

            for (int i = 1; i <= 10; i++)
            {
                Console.Write(i + ". Sayıyı Giriniz: ");
                int sayi = Convert.ToInt32(Console.ReadLine());

                if (i == 5)
                {
                    bolen = sayi;

                }
                toplam += sayi;


            }
            sonuc = toplam / bolen;

            Console.WriteLine();
            Console.WriteLine("Toplam: " + toplam);
            Console.WriteLine("Bölen sayı: " + bolen);
            Console.WriteLine("Sonuç: " + sonuc + " --> " + sonuc.ToString("n2"));
            //Console.WriteLine(sonuc.ToString("n2")); //çıkan sonucun virgülden sonraki 2 basamağını alır ve n yanına sayıyı kaç yazarsan virgülden sonra o kadar sayıyı gösterir

            Console.Read();
        }
    }
}
