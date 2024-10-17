using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hafta3_Console_Random01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Rastgele Üretilen 10 sayının toplamını veren program

            Random sayi = new Random();


            int toplam = 0;
            int sayac = 0;

            for (int i = 1; i <= 10; i++)
            {
                sayac++;
                int rastgele = sayi.Next(100, 501);
                Console.WriteLine( sayac + ". Sayı: " + rastgele);
                toplam += rastgele; //toplam = toplam + rastgele
                
            }


            Console.WriteLine("Toplam Sonuç: " + toplam);

            Console.Read();
        }
    }
}
