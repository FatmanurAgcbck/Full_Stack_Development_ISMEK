using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hafta7_Console_GenelUygulama
{
    internal class BireyselMusterliler : Musteriler 
    { 
        public int krediPuan;
        public int faizTutar;

        public void BireyselM()
        {
            VeriAl();
            Console.Write("Kredi Puanı Giriniz: ");
            krediPuan = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Faiz Tutarını Giriniz: ");
            faizTutar = Convert.ToInt32(Console.ReadLine());

            Yazdir();
            Console.WriteLine("Faiz tutarı: " + faizTutar);
            Console.WriteLine("Kredi puanı: " + krediPuan);
        }

        public int Zam(int fiyat, int kPuan)
        {
            if(kPuan > 100)
            {
                fiyat += fiyat * 5 / 100;
                return fiyat;
            }
            else
            {

                return fiyat;
            }
        }

        public void Kampanya(int tutar)
        {
            if(tutar > 50000)
            {
                Console.WriteLine("Tebrikler 1 Hafta Tatil Kazandınız!");
            }
            else
            {
                Console.WriteLine("2 Gün Tatil Kazandınız!");
            }
        }
    }
}
