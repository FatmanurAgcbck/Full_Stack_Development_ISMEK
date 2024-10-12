using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hafta2_Console_Donguler08
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //dışarıdan girilen başlangıç ve bitiş sayılarının yine dışarıdan girilen sayıya bölünen sayıların adedi

            Console.Write("Başlangıç sayısını girin: ");
            int baslangic = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();

            Console.Write("Bitiş sayısını girin: ");
            int bitis = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();

            Console.Write("Bölen sayıyı girin: ");
            int bolen = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();
            int adet = 0;

            for (int i = baslangic; i < bitis; i++)
            {
                if (i % bolen == 0)
                {

                    adet++;
                    Console.WriteLine(i + $" --> Girilen {bolen} sayısına tam bölünür");
                }
            }
            Console.WriteLine();
            Console.WriteLine("Girilen Sayıya Göre Bölünen Sayıların Toplam Adedi: " + adet);

            Console.Read();
        }
    }
}
