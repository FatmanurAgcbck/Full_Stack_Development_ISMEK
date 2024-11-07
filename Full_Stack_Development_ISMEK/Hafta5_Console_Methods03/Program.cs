using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hafta5_Console_Methods03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //overloading --> aşırı yükleme bir metot ismi üzerinden parametrelerini değiştirerek o metodu kullanma

            //2 yazılı ortalama hesabı 
            //2 yazılı + 1 sözlü ortalama hesabı
            //2 yazılı + 1 sözlü + ödev ortalama hesabı

            Console.WriteLine(Ortalama(40,80));
            Console.WriteLine(Ortalama(40,80,60));
            Console.WriteLine(Ortalama(40,80,60,30));

     


            Console.Read();


        }

        static double Ortalama(int yazili1, int yazili2)
        {

            double sonuc = (yazili1 + yazili2) / 2;
            return sonuc;
        }

        static double Ortalama(int yazili1, int yazili2, int sozlu)
        {
            double sonuc = (yazili2 + yazili1 + sozlu) / 3;
            return sonuc;
        }
        
        static double Ortalama(int yazili1, int yazili2, int sozlu, int odev)
        {
            double sonuc = (yazili2 + yazili1 + sozlu + odev) / 4;
            return sonuc;
        }
    }
}
