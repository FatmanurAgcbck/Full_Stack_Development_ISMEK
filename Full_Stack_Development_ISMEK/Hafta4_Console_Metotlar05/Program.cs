using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hafta4_Console_Metotlar05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // NotHesapla metodlu parametreli geriye değer döndürmeyen
            //kullanıcıdan ilkokul ortaokul lise de mi okuyor bilgisi alınsın bunun üzerine not hesaplaması yapılsın
            //okul durumuna göre not hesaplaması yapan program

            Console.WriteLine("Lütfen Seçim Yapınız...");
            Console.WriteLine("1 - İlkokul");
            Console.WriteLine("2 - Ortaokul");
            Console.WriteLine("3 - Lise");
            

            int okul = Convert.ToInt32(Console.ReadLine());

            if (okul == 1)
            {
                Console.Write("1.Sınav Notu: ");
                int not1 = Convert.ToInt32(Console.ReadLine());
                Console.Write("2.Sınav Notu: ");
                int not2 = Convert.ToInt32(Console.ReadLine());

                NotHesapla1(not1, not2);
            }
            if (okul == 2)
            {
                Console.Write("1.Sınav Notu: ");
                int not1 = Convert.ToInt32(Console.ReadLine());
                Console.Write("2.Sınav Notu: ");
                int not2 = Convert.ToInt32(Console.ReadLine());
                Console.Write("Sözlü Notu: ");
                int sozlu = Convert.ToInt32(Console.ReadLine());

                NotHesapla2(not1, not2, sozlu);
            }
            if (okul == 3)
            {
                Console.Write("1.Sınav Notu: ");
                int not1 = Convert.ToInt32(Console.ReadLine());
                Console.Write("2.Sınav Notu: ");
                int not2 = Convert.ToInt32(Console.ReadLine());
                Console.Write("Sözlü Notu: ");
                int sozlu = Convert.ToInt32(Console.ReadLine());
                Console.Write("Performans Notu: ");
                int per = Convert.ToInt32(Console.ReadLine());

                NotHesapla3(not1, not2, sozlu, per);
            }

            Console.Read();
        }


        public static void NotHesapla1(int n1, int n2)
        {
            int ortalama = (n1 + n2) / 2;
            Console.WriteLine("Ortalama = " + ortalama);
        }

        public static void NotHesapla2(int n1, int n2,int sozlu)
        {
            int ortalama = (n1 + n2  + sozlu ) / 3;
            Console.WriteLine("Ortalama = " + ortalama);
        }

        public static void NotHesapla3(int n1, int n2, int sozlu, int pn)
        {
            int ortalama = (n1 + n2 + sozlu + pn) / 4;
            Console.WriteLine("Ortalama = " + ortalama);
        }

    }
}
