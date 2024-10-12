using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hafta2_Console_Donguler03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //10 ile 30 arasındaki sayıların ortalaması

            int toplam = 0;
            int sayac = 0;
            float ortalamala = 0;

            for (int i = 10; i < 30; i++)
            {
                sayac++;
                toplam += i;
            }

            ortalamala = toplam / (float)sayac; //int olan sayacı float a dönüştürdü  -> (float)

            Console.WriteLine("Toplam: " + toplam);
            Console.WriteLine("Sayaç: " + sayac);
            Console.WriteLine("Ortalama: " + ortalamala);



            Console.Read();
        }
    }
}
