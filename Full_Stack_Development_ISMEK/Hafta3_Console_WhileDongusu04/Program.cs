using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hafta3_Console_WhileDongusu04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //klavyeden negatif sayı girilene kadar girilen diğer sayıları toplayan program

            int sayi = 0;
            int toplam = 0;

            while (sayi >= 0)
            {
                Console.Write("Sayı Giriniz: ");
                sayi = Convert.ToInt32(Console.ReadLine());

                if (sayi >= 0)
                {
                    toplam += sayi;

                }

            }
            Console.WriteLine();
            Console.WriteLine("Toplam: " + toplam);



            Console.Read();
        }
    }
}
