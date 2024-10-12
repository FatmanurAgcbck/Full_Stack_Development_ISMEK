using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hafta2_Console_Donguler05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //If - else

            //dışarıdan girilen 10 sayının çift olanlarının toplamı
            //

            int toplam = 0;



            for (int i = 1; i <= 10; i++)
            {
                Console.Write(i + " . Sayıyı Giriniz: ");
                int sayi = Convert.ToInt32(Console.ReadLine());

                if (sayi % 2 == 0)
                {
                    toplam += sayi;

                }



            }
            Console.WriteLine("Çift Sayıların Toplamı: " + toplam);


            Console.Read();
        }
    }
}
