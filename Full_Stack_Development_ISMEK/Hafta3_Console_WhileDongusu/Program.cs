using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hafta3_Console_WhileDongusu
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //şartı kontrol eder 
            //şart sağlanana kadar çalışır

            //1 ve 100 arasında tutulan sayıların sadece 5 e bölünenlerin toplamı 1000 i bulan program

            Random rnd = new Random();
            
            go:
            int toplam = 0;

            while (toplam < 1000)
            {
                int sayi = rnd.Next(1,100);

                if (sayi % 5 == 0)
                {
                    Console.WriteLine("Sayı: " + sayi);
                    toplam += sayi;
                }
                
            }
            if (toplam != 1000)
            {
                goto go;
            }
            else
            {
                Console.WriteLine("Sonuç: " + toplam);
            }
            

            Console.Read();
        }
    }
}
