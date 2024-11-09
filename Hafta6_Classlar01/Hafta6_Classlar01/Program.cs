using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hafta6_Classlar01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Insan insan1 = new Insan();
            insan1.adsoyad = "Nur Ağaç";
            insan1.adres = "İstanbul";
            insan1.boy = 161;
            insan1.yas = 23;
            insan1.kilo = 65;

            Console.WriteLine("Ad Soyad: " + insan1.adsoyad);
            Console.WriteLine("Adres: " + insan1.adres);
            Console.WriteLine("Yaş: " + insan1.yas);
            Console.WriteLine("Boy: " + insan1.boy);
            Console.WriteLine("Kilo: " + insan1.kilo);
            

        }
    }
}
