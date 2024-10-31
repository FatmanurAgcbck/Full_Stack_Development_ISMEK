using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hafta4_Console_Array01
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //diziler birden çok öğeyi tek bir değişken altında depolamak için kullanılır

            //dizinin elemanlarını dışarıdan alan ve boyutunu kullanıcının belirlediği program

            //dizi boyutunu belirler
            Console.Write("Dizi Boyutunu Giriniz: ");
            int boyut =Convert.ToInt32(Console.ReadLine());

            int[] yas = new int[boyut];

           //dizinin boyutu kadar eleman girilmesini sağlar
            for (int i = 0; i < boyut; i++)
            {
                Console.Write(i+1+". Yaşı Giriniz:");
                yas[i] = Convert.ToInt32(Console.ReadLine());
            }

            Console.WriteLine();
            //girilen değerleri ekrana yazdırır
            for (int i = 0;i < yas.Length; i++)
            {
                Console.WriteLine("Girilen Değerler: " + yas[i]);

            }

            Console.Read();

        }
    }
}
