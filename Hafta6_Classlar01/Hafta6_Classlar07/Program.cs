using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hafta6_Classlar07
{
    internal class Program
    {
        static void Main(string[] args)
        {

           


            Console.WriteLine("Seçiminizi Yapın");
            Console.WriteLine("1 - İlkokul");
            Console.WriteLine("2 - Lise");
            Console.WriteLine("3 - Üniversite");


            int secim = Convert.ToInt32(Console.ReadLine());

            if (secim == 1)
            {
                Ogrenciler ogrenc1 = new Ogrenciler();
                Console.Write("Tc No Giriniz: ");
                ogrenc1.TcNo = Console.ReadLine();

                Console.Write("Öğrenci No Giriniz: ");
                ogrenc1.OgrenciNo = Console.ReadLine();

                Console.Write("Ad Soyad Giriniz: ");
                ogrenc1.adSoyad = Console.ReadLine();

                Console.Write("Not Giriniz: ");
                ogrenc1.Not =int.Parse(Console.ReadLine());

                Console.Write("Burs Giriniz: ");
                ogrenc1.burs = int.Parse(Console.ReadLine());

                
                

                Console.Clear();
                Console.WriteLine("TC No: " + ogrenc1.TcNo);
                Console.WriteLine("Öğrenci No: " + ogrenc1.OgrenciNo);
                Console.WriteLine("Adı Soyadı: " + ogrenc1.adSoyad);
                Console.WriteLine("Notu: " + ogrenc1.Not);
                Console.WriteLine("Burs Tutarı: " + ogrenc1.burs);

                int totalBurs = ogrenc1.BursVer(ogrenc1.Not, ogrenc1.burs);
                Console.WriteLine("Toplam Burs: " + totalBurs );
                ogrenc1.Hediye(totalBurs);
            }
            else if (secim == 2)
            {
                Ogrenciler ogrenc1 = new Ogrenciler();
                Console.Write("Tc No Giriniz: ");
                ogrenc1.TcNo = Console.ReadLine();

                Console.Write("Öğrenci No Giriniz: ");
                ogrenc1.OgrenciNo = Console.ReadLine();

                Console.Write("Ad Soyad Giriniz: ");
                ogrenc1.adSoyad = Console.ReadLine();

                Console.Write("Not Giriniz: ");
                ogrenc1.Not = int.Parse(Console.ReadLine());

                Console.Write("Burs Giriniz: ");
                ogrenc1.burs = int.Parse(Console.ReadLine());




                Console.Clear();
                Console.WriteLine("TC No: " + ogrenc1.TcNo);
                Console.WriteLine("Öğrenci No: " + ogrenc1.OgrenciNo);
                Console.WriteLine("Adı Soyadı: " + ogrenc1.adSoyad);
                Console.WriteLine("Notu: " + ogrenc1.Not);
                Console.WriteLine("Burs Tutarı: " + ogrenc1.burs);

                int totalBurs = ogrenc1.BursVer(ogrenc1.Not, ogrenc1.burs);
                Console.WriteLine("Toplam Burs: " + totalBurs);
                ogrenc1.Hediye(totalBurs);
            }
            else if (secim == 3)
            {
                Ogrenciler ogrenc1 = new Ogrenciler();
                Console.Write("Tc No Giriniz: ");
                ogrenc1.TcNo = Console.ReadLine();

                Console.Write("Öğrenci No Giriniz: ");
                ogrenc1.OgrenciNo = Console.ReadLine();

                Console.Write("Ad Soyad Giriniz: ");
                ogrenc1.adSoyad = Console.ReadLine();

                Console.Write("Not Giriniz: ");
                ogrenc1.Not = int.Parse(Console.ReadLine());

                Console.Write("Burs Giriniz: ");
                ogrenc1.burs = int.Parse(Console.ReadLine());




                Console.Clear();
                Console.WriteLine("TC No: " + ogrenc1.TcNo);
                Console.WriteLine("Öğrenci No: " + ogrenc1.OgrenciNo);
                Console.WriteLine("Adı Soyadı: " + ogrenc1.adSoyad);
                Console.WriteLine("Notu: " + ogrenc1.Not);
                Console.WriteLine("Burs Tutarı: " + ogrenc1.burs);

                int totalBurs = ogrenc1.BursVer(ogrenc1.Not, ogrenc1.burs);
                Console.WriteLine("Toplam Burs: " + totalBurs);
                ogrenc1.Hediye(totalBurs);
            }

            
            

            


            Console.Read();
        }
    }
}
