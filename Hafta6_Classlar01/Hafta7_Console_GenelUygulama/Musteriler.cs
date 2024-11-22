using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hafta7_Console_GenelUygulama
{
    internal class Musteriler
    {

        public int MusteriNo;
        public string mAdSoyad;
        public string telNo;
        public string adres;
        private int alimAdet;
        private int toplamAlim;
        public int fiyat;


        public int AlimAdet
        {
            get
            {
                return alimAdet;
                
            }
            set
            {
                if (value > 1 && value < 100)
                {
                    alimAdet = value;
                }
                else
                {
                    Console.WriteLine("Geçersiz Adet Girişi! 1 ile 100 arasında değer giriniz.");
                }
            }
        }

        public int ToplamAlim
        {
            get
            {
                return toplamAlim;
            }
            set
            {
                if(value >= 100 && value <= 500)
                {
                    toplamAlim = value;
                }
                else
                {
                    Console.WriteLine("Geçersiz Giriş! 100 ile 500 arasında değer giriniz");
                }
            }
        }

        public int Tutar(int topAdet, int fiyat)
        {
            if(topAdet > 100 && topAdet < 200)
            {
                fiyat -= fiyat * 5 / 100;
                return fiyat;
            }
            else if(topAdet > 200 && topAdet < 500)
            {
                fiyat -= fiyat * 25 / 100;
                return fiyat;
            }
            else
            {
                return fiyat;

            }
        }
        public void Yazdir()
        {
            Console.WriteLine("Müşteri No: " + MusteriNo);
            Console.WriteLine("Ad Soyad: " + mAdSoyad);
            Console.WriteLine("Telefon: " + telNo);
            Console.WriteLine("Adres: " + adres);
            Console.WriteLine("Alım Adet: " + AlimAdet);
            Console.WriteLine("Toplam Alım: " + ToplamAlim);
            Console.WriteLine("Fiyat: " + fiyat);
            Console.WriteLine("Ödenecek Tutar: " + Tutar(ToplamAlim, fiyat));

        }

        public void VeriAl()
        {
            Console.Write("Müşteri Numarasını Giriniz: ");
            MusteriNo=Convert.ToInt32(Console.ReadLine());
            Console.Write("Müşteri Adı Soyadı: ");
            mAdSoyad = Console.ReadLine();
            Console.Write("Müşteri Telefon Numarası: ");
            telNo = Console.ReadLine();
            Console.Write("Müşteri Adresi: ");
            adres = Console.ReadLine();
            Console.Write("Alım Adet Giriniz: ");
            AlimAdet=Convert.ToInt32(Console.ReadLine());
            Console.Write("Toplam Alım Giriniz: ");
            ToplamAlim=Convert.ToInt32(Console.ReadLine());
            Console.Write("Fiyat Giriniz: ");
            fiyat = Convert.ToInt32(Console.ReadLine());
        }
    }
}
