using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hafta2_Console_Random
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //random rastgele değer atama

            //10 ile 100 arasında rastgele sayı üretme

            Random rastgele = new Random();

            int sayi = rastgele.Next(10, 100); //ilk yazılan dahil ikinci yazılan dahil değil yani 10 dahil 100 dahil değil yani 10'dan 99'a kadar sayı üretir
            Console.WriteLine("Rastgele gelen tam sayı: " + sayi);

            Console.WriteLine();

            double sayi1 = rastgele.NextDouble() * (200); //* dan sonra yazılan sayı hangi aralıkta sayı üreteceğini belirler (200 ile 0 arasında sayı üretir)
            Console.WriteLine("Rastgele gelen double sayı: " + sayi1);



            Console.Read();
        }
    }
}
