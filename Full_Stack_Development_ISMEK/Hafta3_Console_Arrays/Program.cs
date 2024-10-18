using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hafta3_Console_Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //dizi (array) -- > ayni tipte olan birden çok veriyi saklar



            int[] sayilar = new int[3];
            sayilar[0] = 102;
            sayilar[1] = 847;
            sayilar[2] = 463;

            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine(sayilar[i]);
            }

            Console.Read();

        }
    }
}
