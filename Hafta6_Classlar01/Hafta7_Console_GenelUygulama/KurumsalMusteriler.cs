using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Hafta7_Console_GenelUygulama
{
    internal class KurumsalMusteriler:Musteriler
    {
        int faaliyetYili;
        int ticariOran;
        int yillikCiro;


        public int FaaliyetYili
        {
            get
            {
                return faaliyetYili;
            }
            set
            {
                if (value >= 5 && value <= 20)
                {
                    faaliyetYili = value;
                }
                else
                {
                    Console.WriteLine("Hatalı Giriş Yapıldı!");
                }
            }
        }

        public int TicariOran
        {
            get
            {
                return ticariOran;
            }
            set
            {
                if (value >= 5 && value <= 50)
                {
                    ticariOran = value;
                }
                else
                {
                    Console.WriteLine("Hatalı Giriş Yapıldı!");
                }
            }
        }

        public int YillikCiro
        {
            get
            {
                return yillikCiro;
            }
            set
            {
                if(value < 1000000)
                {
                    yillikCiro = value;
                }
                else
                {
                    Console.WriteLine("Hatalı Giriş Yapıldı!");
                }
            }
        }

        public int Indirim(int yil, int oran, int fiyat)
        {
            if (yil > 5 && yil < 10)
            {
                int tutar = fiyat * oran;
                tutar -= tutar * 5 / 100;
                return tutar;
            } 
            else if(yil > 10 && yil < 20)
            {

                int tutar =fiyat * oran;
                tutar -= tutar * 10 / 100;
                return tutar;
            }
            else
            {
                int tutar = fiyat * oran;
                return tutar;
            }
        }

        public void Vergi(int indirimTutar)
        {
            indirimTutar += indirimTutar * 2 / 100;
            Console.WriteLine("Toplam Tutar: " + indirimTutar);
        }

        public void KurumsalM()
        {
            VeriAl();
            Console.Write("Faaliyet Yılı Giriniz: ");
            FaaliyetYili = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ticari Oran Giriniz: ");
            TicariOran = Convert.ToInt32(Console.ReadLine());
            Console.Write("Yıllık Ciro Giriniz:  ");
            YillikCiro = Convert.ToInt32(Console.ReadLine());

            Yazdir();
            Console.WriteLine("Faaliyet Yılı: " + FaaliyetYili);
            Console.WriteLine("Ticari Oran: " + TicariOran);
            Console.WriteLine("Yıllık Ciro: " + YillikCiro);

            int indirim = Indirim(FaaliyetYili,  TicariOran, YillikCiro);
            Console.WriteLine("İndirim: " + indirim);

            Vergi(indirim);
            
        }
    }
}
