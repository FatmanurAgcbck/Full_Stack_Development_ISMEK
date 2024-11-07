using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hafta5_Console_DoWhile03
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //10 dan 0 a kadar olan sayıları yazdıran program


            int sayac = 10;

            do
            {
                Console.WriteLine("Sayı: " + sayac);
                sayac--;
                
            }
            while (sayac > 0);


            Console.Read();
        }
    }
}
