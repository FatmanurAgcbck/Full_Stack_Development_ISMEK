using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hafta7_Console_GenelUygulama
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //Musteriler ana class
            //kurumsalMusteriler ve BireyselMusteriler 2 class
            //faaliyet yılı 5 - 20 arasında olanları alsın
            //ticari oran 5 - 50 arasında 
            //yıllık ciro 1000000 üstü olmasın

            //returnlu metot faaliyetYılı
            //5 ile 10 yıl arasında ise fiyat*ticariOran dan %5 indirim
            //10 ile 20 yıl arasında ise fiyat*ticariOran dan %10 indirim
            //void metotdu ile bir önceki metotdan dönen değere göre %2 vergi uygula ve toplam tutarı bul
            //not: returnlu metotdan dönen değeri voidli metota aktar



            Console.WriteLine("1- Bireysel Müşteri");
            Console.WriteLine("2- Kurumsal Müşteri");
            Console.WriteLine("--------------------------------");
            int secim = Convert.ToInt32(Console.ReadLine());

            if (secim == 1)
            {
                BireyselMusterliler m1 = new BireyselMusterliler();
                m1.BireyselM();
            }
            else if (secim == 2) 
            {
                KurumsalMusteriler m2 = new KurumsalMusteriler();
                m2.KurumsalM();
            }


            Console.Read();
        }
    }
}
