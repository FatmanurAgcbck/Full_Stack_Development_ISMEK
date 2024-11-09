using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hafta6_Classlar05
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Ogrenci ogreci1 = new Ogrenci();

            ogreci1.Adı = "Deniz";
            ogreci1.Soyadı = "Tekin";
            ogreci1.Yas = 2;


            Console.WriteLine("Adı: " + ogreci1.Adı);
            Console.WriteLine("Soyadı: " + ogreci1.Soyadı);
            Console.WriteLine("Yaşı: " + ogreci1.Yas);


            Console.Read();
        }
    }
}
