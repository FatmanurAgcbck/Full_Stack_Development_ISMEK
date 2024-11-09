using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Hafta6_Classlar_Kalıtım01
{
    internal class Kamyon : MotorluTasitlar
    {
        public int agirlik;
        public string kasaTipi;

        public void kamyonVeriAl()
        {
            Console.WriteLine("*************** KAMYON VERİ ALMA ***************");
            VeriAl();
            Console.Write("Ağırlık Giriniz: ");
            agirlik = Convert.ToInt32(Console.ReadLine());

            Console.Write("Kasa Tipi Giriniz: ");
            kasaTipi = Console.ReadLine();
        }

        public void KamyonYazdir()
        {
            Console.WriteLine("*************** OTOMOBİL ÖZELLİKLERİ ***************");
            Yazdır();
            Console.WriteLine("Ağırlık: " + agirlik);
            Console.WriteLine("Kasa Tipi: " + kasaTipi);
        }


    }
}
