using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hafta1_Console_Degiskenler2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("İsminizi Giriniz: ");
            string ad = Console.ReadLine();

            Console.WriteLine("Mezuniyet Notunu Giriniz: ");
            float not = Convert.ToSingle(Console.ReadLine());

            Console.WriteLine("Tecrübe Yılını Giriniz: ");
            int tyil = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Cinsiyeti Giriniz E/K: ");
            char cinsiyet = Convert.ToChar(Console.ReadLine());

            Console.WriteLine("Ödeme Tutarı Giriniz: ");
            int tutar = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("KDV Giriniz: ");
            int kdv = Convert.ToInt32(Console.ReadLine());

            int sonuc;
            sonuc = tutar * kdv / 100;
            sonuc += tutar;

            Console.WriteLine("Ödenmesi Gereken KDV'li Tutar: " + sonuc);

            Console.ReadKey();
        }
    }
}
