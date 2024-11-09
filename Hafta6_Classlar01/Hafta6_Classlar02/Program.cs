using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hafta6_Classlar02
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Ogrenciler ogrenci1 = new Ogrenciler();

            Console.Write("Öğrenci Numarası Giriniz: ");
            ogrenci1.OgrenciNo = Convert.ToInt32(Console.ReadLine());

            Console.Write("Öğrencinin Adı Soyadı: ");
            ogrenci1.AdSoyad = Console.ReadLine();

            Console.Write("Öğrenci Adresi: ");
            ogrenci1.Adres = Console.ReadLine();

            Console.Write("Öğrenci Ortalama Notu: ");
            ogrenci1.Ortalama = Convert.ToInt32(Console.ReadLine());

            Console.Clear();

            Console.WriteLine("------ Öğrenci Bilgi Ekranı -----");
            Console.WriteLine("Öğrenci Numarası:  " + ogrenci1.OgrenciNo);
            Console.WriteLine("Adı Soyadı: " + ogrenci1.AdSoyad);
            Console.WriteLine("Adres: " + ogrenci1.Adres);
            Console.WriteLine("Not Ortalaması: " + ogrenci1.Ortalama);

            ogrenci1.Burs();

            Console.Read();
        }
    }
}
