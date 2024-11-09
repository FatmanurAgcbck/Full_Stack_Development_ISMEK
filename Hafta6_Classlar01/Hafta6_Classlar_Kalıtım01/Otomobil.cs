using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hafta6_Classlar_Kalıtım01
{
    internal class Otomobil : MotorluTasitlar
    {
        public string model;
        public int kapiSayisi;

        public void otoVeriAl()
        {
            Console.WriteLine("*************** OTOMOBİL VERİ ALMA EKRANI ***************");
            VeriAl();
            Console.Write("Model Giriniz: ");
            model = Console.ReadLine();

            Console.Write("Kapı Sayısı Giriniz: ");
            kapiSayisi = int.Parse(Console.ReadLine());
        }

        public void OtoYazdir()
        {
            Console.WriteLine("*************** OTOMOBİL ÖZELLİKLERİ ***************");
            Yazdır();
            Console.WriteLine("Model: " + model);
            Console.WriteLine("Kapı Sayısı: " + kapiSayisi);
        }

    }
}
