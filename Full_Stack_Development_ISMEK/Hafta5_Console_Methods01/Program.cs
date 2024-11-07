using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hafta5_Console_Methods01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //metod kullanarak girilen iki sayıdan büyük olanı ekrana yazdıran program


            Console.Write("1.Sayıyı Girin ");
            int s1 = Convert.ToInt32(Console.ReadLine());
            
            Console.Write("2.Sayıyı Girin ");
            int s2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Büyük Sayı = " + BuyukSayi(s1, s2));

            Console.Read();
        }


        static int BuyukSayi(int sayi1, int sayi2)
        {
            if (sayi1 > sayi2)
            {
                return sayi1;
            }
            else if ( sayi2 > sayi1)
            {
                return sayi2;
            }
            else
            {
                return sayi1;
            }
        }
    }
}
