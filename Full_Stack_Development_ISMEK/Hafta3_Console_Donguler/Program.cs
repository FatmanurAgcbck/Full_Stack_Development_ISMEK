using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hafta3_Console_Donguler
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //10 ile 100 arasında 7 tane random değer üreten ve üretilen değerlerin 2 ve 7 ye bölünenlerin adedini bulan program

            int sayac = 0;
            Random rnd = new Random();


            for (int i = 0; i < 7; i++)
            {
                int sayi = rnd.Next(10, 101);
                Console.WriteLine("Sayı: " + sayi);

                if (sayi % 2 == 0 && sayi % 7 == 0)
                {
                    sayac++;
                    
                }
               
            }
            Console.WriteLine(sayac + " tane 2 ve 7 ye bölünen sayı var");
            Console.Read();
        }
    }
}
