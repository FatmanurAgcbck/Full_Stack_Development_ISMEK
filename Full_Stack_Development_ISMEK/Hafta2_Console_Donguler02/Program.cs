using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hafta2_Console_Donguler02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //5 ile 30 arasındaki sayıların toplamı 


            int toplam = 0;

            for (int i = 5; i < 30; i++)
            {
                Console.WriteLine("Sayılar: " + i);
                toplam += i;

            }
            Console.WriteLine();
            Console.WriteLine("Toplam: " + toplam);

            Console.Read();
        }
    }
}
