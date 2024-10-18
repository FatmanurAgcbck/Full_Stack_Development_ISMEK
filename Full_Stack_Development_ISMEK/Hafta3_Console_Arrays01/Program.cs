using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace Hafta3_Console_Arrays01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //tanımlanan sayılar dizisi içindeki sayıları toplayan program

            //int[] sayilar = { 5, 10, -20, -30, -40, 80, 90, 100 };

            //int toplam = 0;


            //foreach (int sayi in sayilar)
            //{
            //    toplam += sayi;
            //}

            ////for (int i = 0; i < sayilar.Length; i++)
            ////{
            ////    toplam += sayilar[i];
            ////}
            //Console.WriteLine("Toplamı: " + toplam);



            //string bir dizi oluştur 3 isim girilsin ve ekranda yazdırılsın


            string[] isim = {"Ali", "Veli", "Ayşe" };
            Console.WriteLine(isim[0]); //girilen indexteki değeri getirir

            foreach (string i in isim)
            {
                Console.WriteLine(i);  //hepsini yazdırır
            }

            Console.Read();
        }
    }
}
