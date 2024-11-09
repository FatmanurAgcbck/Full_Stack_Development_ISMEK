using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hafta6_Classlar06
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Personel personel1 = new Personel();

            personel1.pAd = "metin";
            personel1.pSoyad = "çetin";
            personel1.yas = 18;
            personel1.Kimlik = "1234567891112";





            Console.WriteLine("Ad: " + personel1.pAd);
            Console.WriteLine("Soyad: " + personel1.pSoyad);
            Console.WriteLine("Yaş: " + personel1.yas);
            Console.WriteLine("T.C.: " + personel1.Kimlik);



            Console.Read();


        }
    }
}