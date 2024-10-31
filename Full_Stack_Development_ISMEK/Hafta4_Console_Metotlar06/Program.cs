using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Hafta4_Console_Metotlar06
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Züccaciye 
            //mutfak gereçleri - 1
            //oda gereçleri - 2

            //1 a tencere takımı
            //b yemek takımı

            //parametreli vergihesaplama %18 kdv 
            //hediye adında metot
            //eğer ürün fiyatı 100 ile 1000 arasında ise %10 indirim
            //1000 ile 8000 arasında ise %15 indirim + süpürge hediye etsin
            //fiyat 8000 ve üzerinde %20 indirim 

            

            
            Console.WriteLine("1 - Mutfak Gereçleri");
            Console.WriteLine("2 - Oda Gereçleri");
            Console.WriteLine();
            Console.Write("Lütfen Seçiniz... ");
            string secim = Console.ReadLine();
            Console.WriteLine();

            if (secim == "mutfak")
            {
                Console.WriteLine("a - Tencere Takımı");
                Console.WriteLine("b - Yemek Takımı");
                Console.Write("Tekrar Seçiminizi Yapın ");
                string secenek = Console.ReadLine();
                Console.WriteLine();

                if(secenek == "a")
                {
                    Console.Write("Fiyatı Giriniz: ");
                    int fiyat = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Adet Giriniz: ");
                    int adet = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine();
                    float toplam = VergiHesapla(adet, fiyat);
                    Console.WriteLine("Toplam Tutar = " + toplam);
                    Console.WriteLine();
                    SonTutar(toplam);
                }
                if(secenek == "b")
                {
                    Console.Write("Fiyatı Giriniz: ");
                    int fiyat = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Adet Giriniz: ");
                    int adet = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine();
                    float toplam = VergiHesapla(adet, fiyat);
                    Console.WriteLine("Toplam Tutar = " + toplam);
                    Console.WriteLine();
                    SonTutar(toplam);
                }
            }
            if (secim == "oda")
            {
                Console.WriteLine("Oda Gereçlerini Seçtiniz İyi Günlerde Kullanın");
            }

            Console.Read();
        }

        static float VergiHesapla(int adet, int fiyat)
        {
            fiyat *= adet;
            float kdv = fiyat + (fiyat * 18 / 100);
            return kdv;

        }

        public static void SonTutar(float toplam)
        {
            if(toplam >= 100 && toplam < 1000)
            {
                float sonTutar = toplam - (toplam * 10 / 100);
                Console.WriteLine("%10 İndirim Kazandınız... ");
                Console.WriteLine("Son Tutar = " + sonTutar);
            }
            else if(toplam >= 1000 && toplam < 8000)
            {
                float sonTutar = toplam - (toplam * 15 / 100);
                Console.WriteLine("%15 İndirim ve Süpürge Kazandınız...");
                Console.WriteLine("Son Tutar = " + sonTutar);
            }
            else if (toplam >= 8000)
            {
                float sonTutar = toplam - (toplam * 20 / 100);
                Console.WriteLine("%20 İndirim Kazandınız... " );
                Console.WriteLine("Son Tutar = " + sonTutar);
            }
        }
    }
}
