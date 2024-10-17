using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hafta3_Console_WhileDongusu02
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //1 den 5 e kadar olan sayıların toplamı 

            int toplam = 0;
            int sayi = 1;

            while (sayi <= 5)
            {

                toplam += sayi;
                sayi++;
            }
            Console.WriteLine("Toplam: " + toplam);




            Console.Read();



        }
    }
}
