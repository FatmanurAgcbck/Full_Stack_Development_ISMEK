using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hafta4_Console_Metotlar
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //erişimBiçimi geriDönüşTipi metotAdı(parametre) {metodun içinde çalısacak kodlar}
            //public private protected internal --> erişim biçimi. yazılmazsa otomatik olarak private atar


            // geriye değer döndürmeyen --> void
            // parametreli metot adından sonra parantez içerisine yazılır 
            //private void metot1(int x, int y){}


            


            Console.Write("1. Sayıyı Giriniz: ");
            int sayi1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("2. Sayıyı Giriniz: ");
            int sayi2 = Convert.ToInt32(Console.ReadLine());


            Topla(sayi1, sayi2);


            Console.Read();
        }


        //public static void Topla() //geriye değer döndürmeyen parametresiz
        //{
        //    int toplam = 10 + 20; 
        //    Console.WriteLine("Toplam Sonuç: " + toplam);
        //}


        public static void Topla(int sayi1, int sayi2) //geriye değer döndürmeyen parametreli
        {
            int toplam = sayi1 + sayi2;
            Console.WriteLine("Toplam Sonuç: " + toplam);
        }
    }
}
