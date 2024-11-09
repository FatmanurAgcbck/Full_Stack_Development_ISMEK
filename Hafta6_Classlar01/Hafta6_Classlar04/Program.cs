using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hafta6_Classlar04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Musteriler musteri1 = new Musteriler();
            Console.Write("Müşteri No Giriniz: ");
            musteri1.Mno = Convert.ToInt32(Console.ReadLine());

            Console.Write("Müşteri Adresi: ");
            musteri1.MAdres = Console.ReadLine();

            Console.Write("Bakiye Giriniz: ");
            musteri1.Bakiye = Convert.ToSingle(Console.ReadLine());


            Console.Read();

        }
    }
}
