using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hafta6_Classlar_Kalıtım01
{
    internal class MotorluTasitlar
    {
        public int TasitNo;
        public int yakitLitre;
        string vitesDr;
        public string plaka;
        int fiyat;
        string donanım;

        public string VitesDurumu
        {
            get
            {
                return vitesDr;
            }
            set
            {
                if (value == "otomatik" || value == "manuel")
                {
                    vitesDr = value;
                }
                else
                {
                    Console.WriteLine("Yanlış Giriş Yaptınız!");

                }
            }
        }

        public int Fiyat
        {
            get
            {
                return fiyat;
            }
            set
            {
                if(value >= 1000000 && value <= 2000000)
                {
                    fiyat = value;
                }
                else
                {
                    Console.WriteLine("Hatalı Giriş Yapıldı!");
                }
            }
        }

        public string Donanım
        {
            get
            {
                return donanım;
            }
            set
            {
                if(value == "boş" || value == "tam")
                {
                    donanım = value;
                }
                else
                {
                    Console.WriteLine("Hatalı Giriş Yapıldı!");
                }
            }
        }

        public void VeriAl()
        {
            Console.Write("Taşıt No Giriniz: ");
            TasitNo = Convert.ToInt32(Console.ReadLine());

            Console.Write("Yakıt Giriniz: ");
            yakitLitre = Convert.ToInt32(Console.ReadLine());

            Console.Write("Vites Durumu Giriniz: ");
            VitesDurumu = Console.ReadLine();//private

            Console.Write("Plaka Giriniz: ");
            plaka = Console.ReadLine();

            Console.Write("Fiyat Durumu Giriniz: ");
            Fiyat =Convert.ToInt32(Console.ReadLine());//private

            Console.Write("Donanım Bilgisi Giriniz: ");
            Donanım = Console.ReadLine(); //private

        }

        public void Yazdır()
        {
            Console.WriteLine("Taşıt No: " + TasitNo);
            Console.WriteLine("Yakıt: " + yakitLitre);
            Console.WriteLine("Vites: " + VitesDurumu);
            Console.WriteLine("Plaka: " + plaka);
            Console.WriteLine("Fiyat: " + Fiyat);
            Console.WriteLine("Donanım: " + Donanım);
        }

    }
}
