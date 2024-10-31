using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hafta4_Console_Array02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //kullanıcının belirlediği eleman sayısı ile dizi için kullanıcı değer girecek ve ortalamaları bulacak program

            double toplam = 0, ortalama = 0;

            Console.Write("Kaç elemanlı dizi oluşturulsun: ");
            int boyut = int.Parse(Console.ReadLine());

            double[] deger = new double[boyut];

            for (int i = 0; i < deger.Length; i++)
            {
                Console.Write("Sayı {0}: " , i + 1);
                deger[i] = Convert.ToDouble(Console.ReadLine());
                toplam += deger[i];
                
            }

            ortalama = toplam / deger.Length;
            Console.WriteLine();
            Console.WriteLine("Toplam: " + toplam);
            Console.WriteLine("Sonuç: " + ortalama);





            Console.Read();
        }
    }
}
