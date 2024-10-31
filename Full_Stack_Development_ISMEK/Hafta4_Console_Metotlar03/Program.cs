using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hafta4_Console_Metotlar03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Kısa Kenar Giriniz:");
            int kk = Convert.ToInt32(Console.ReadLine());
            Console.Write("Uzun Kenar Giriniz: ");
            int uk = Convert.ToInt32(Console.ReadLine());

            Hesapla(kk, uk);

            //Hesapla1();
            Console.Read();
        }

        //static void Hesapla1()  //geriye değer döndürmeyen parametresiz
        //{
        //    Console.Write("Kısa Kenar Girin: ");
        //    int kk = Convert.ToInt32(Console.ReadLine());
        //    Console.Write("Uzun Kenar Girin: ");
        //    int uk = Convert.ToInt32(Console.ReadLine());

        //    int alan = kk * uk;
        //    Console.WriteLine("Alan = " + alan);
        //}

        static void Hesapla(int kk, int uk)
        {
            int alan = kk * uk;
            Console.WriteLine("Alan = " + alan);
        }
    }
}
