using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hafta5_Console_DoWhile02
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //0 10 arası sayıların toplamını ekrana yazdıran işlem

           
            int sayac = 0;
            int toplam = 0;

            do
            {
                
                sayac++;
                Console.WriteLine(sayac);
                toplam += sayac;

            }
            while (sayac < 10); //<= olsaydı 10 kez çalışır  en son 11 i bulurdu ve toplama eklerdi
            //Console.WriteLine("Sayaç Değerleri: " + sayac);
            Console.WriteLine("Toplamı: " + toplam); 

            Console.Read();
        }
    }
}
