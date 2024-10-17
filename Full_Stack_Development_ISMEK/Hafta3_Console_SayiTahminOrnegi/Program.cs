using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hafta3_Console_SayiTahminOrnegi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random sayi = new Random();
            int programTahmin = sayi.Next(1, 21);

            int sayac = 0;

        go:
            try
            {
                Console.Write("Sayı Tahmini Giriniz: ");
                int kullaniciTahmin = Convert.ToInt32(Console.ReadLine());
                sayac++;
                Console.WriteLine();

                if (programTahmin == kullaniciTahmin)
                {
                    Console.WriteLine(sayac + ". tahminde buldunuz...");
                }
                else if (programTahmin > kullaniciTahmin)
                {
                    Console.WriteLine("Daha Büyük Bir Sayı Giriniz");
                    goto go;
                }
                else
                {
                    Console.WriteLine("Daha Küçük Bir Sayı Giriniz");
                    goto go;
                }
            }
            catch (Exception)
            {
                Console.WriteLine("Sayısal Değer Giriniz");
            }



            Console.Read();

            //try catch hata yakalama blogudur
        }
    }
}
