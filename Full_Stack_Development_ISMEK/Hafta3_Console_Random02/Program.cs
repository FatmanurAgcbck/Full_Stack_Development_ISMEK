using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hafta3_Console_Random02
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //Bir komisyoncu sattığı mallardan fiyatı 50 tl ye kadar olanlardan %3 daha fazla olanlardan da %2 komisyon almaktadır klavyeden girilen 5 malın komisyonlarını bulup ekrana yazdıran ve en sonunda toplam komisyonu ekrana yazdıran program



            float komisyon = 0;
            float toplamKomisyon = 0;

            for (int i = 1; i <= 5; i++)
            {
                Console.Write("Ürün fiyatını giriniz: ");
                float fiyat = Convert.ToSingle(Console.ReadLine());

                if (fiyat <= 50)
                {
                    komisyon = fiyat * 3 / 100;
                    toplamKomisyon += komisyon;
                    Console.WriteLine("Ürünün Komisyon Ücreti: " + komisyon);
                    Console.WriteLine();
                }
                else
                {
                    komisyon = fiyat * 2 / 100;
                    toplamKomisyon += komisyon;
                    Console.WriteLine("Ürünün Komisyon Ücreti: " + komisyon);
                    Console.WriteLine();

                }
            }
            Console.WriteLine("Toplam Komisyon: " + toplamKomisyon);



            Console.Read();
        }
    }
}
