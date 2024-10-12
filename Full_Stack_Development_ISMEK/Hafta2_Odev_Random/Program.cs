using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hafta2_Odev_Random
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Kullanıcıya 3 deneme hakkı verildi. 1 - 10 arasında sayı tahmin etmesi istendi

            Random rastgele = new Random();
            int sayi = rastgele.Next(1, 10);

            int tahmin = 0;

            for (int deneme = 1; deneme <= 3; deneme++)
            {
                Console.Write(deneme + ". Deneme --> 1 - 10 Aralığında Bir Sayı Tahmin Ediniz: ");
                tahmin = Convert.ToInt32(Console.ReadLine());


                if (sayi == tahmin)
                {
                    Console.WriteLine();
                    Console.WriteLine($"Doğru Tahmin Ettiniz. {deneme}. Deneme de Buldunuz");
                    Console.WriteLine("Random sayı: " + sayi);
                    break;

                }
                else if (deneme == 3 && sayi != tahmin)
                {
                    Console.WriteLine();
                    Console.WriteLine("Doğru Tahmin Edemediniz");
                    Console.WriteLine("Random Sayı: " + sayi);
                    break;
                }
                else if (tahmin < sayi)
                {
                    Console.WriteLine("Daha Büyük Bir Sayi Girin");
                    Console.WriteLine();
                }
                else
                {
                    Console.WriteLine("Daha Küçük Bir Sayı Girin");
                    Console.WriteLine();
                }


            }

            Console.Read();
        }
    }
}
