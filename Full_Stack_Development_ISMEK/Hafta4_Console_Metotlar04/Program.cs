using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hafta4_Console_Metotlar04
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int sonuc = Hesapla();
            Console.WriteLine("Alan = " + sonuc);
            Console.Read();
        }

        static int Hesapla()
        {
            Console.Write("Kısa Kenar: ");
            int kk = Convert.ToInt32(Console.ReadLine());

            Console.Write("Uzun Kenar: ");
            int uk = Convert.ToInt32(Console.ReadLine());

            int alan = uk * kk;

            return alan;
        }
    }
}
