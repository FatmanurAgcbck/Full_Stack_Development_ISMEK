using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hafta3_Console_WhileDongusu03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //klavyeden 15 girilene kadar sayıları toplamını ekrana yazan program


            int toplam = 0;
            int sayi = 0;


            //15 toplama dahil ediliyor 
            //while (sayi != 15)
            //{
            //    toplam += sayi;
            //    Console.Write("Sayı Giriniz: ");
            //    sayi = Convert.ToInt32(Console.ReadLine());



            //    if (sayi == 15)
            //    {
            //        toplam += sayi;
            //        break;   
            //    }

            //}


            //15 toplama dahil edilmiyor
            while (sayi != 15)
            {
                Console.Write("Sayı Giriniz: ");
                sayi = Convert.ToInt32(Console.ReadLine());

                if (sayi == 15)
                {

                    break;
                }
                toplam += sayi;
            }

            Console.WriteLine();
            Console.WriteLine("Toplam: " + toplam);
            Console.WriteLine("İşlem Bitti...");

            Console.Read();
        }
    }
}
