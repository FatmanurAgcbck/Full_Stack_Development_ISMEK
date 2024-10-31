using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hafta4_Console_Array03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //10 elemanlı dizide kullanıcıdan girilen dizi elemanlarından çiftlerin toplanması
            //teklerin toplamını ayrı ayrı hesaplayıp gösteren program

            double ciftToplam = 0, tekToplam = 0;

            

            for (int i = 0; i < 10; i++)
            {
                
                Console.Write("{0}. sayıyı girin:  ", i + 1);
               double sayi = Convert.ToDouble(Console.ReadLine());

                if (sayi %  2 == 0)
                {
                    ciftToplam += sayi;
                }
                else
                {
                    tekToplam += sayi;
                }
            }
            Console.WriteLine();
            Console.WriteLine("Çift Sayıların Toplamı: {0}  \nTek Sayıların Toplamı: {1}",ciftToplam, tekToplam);
           


            Console.Read();
        }
    }
}
