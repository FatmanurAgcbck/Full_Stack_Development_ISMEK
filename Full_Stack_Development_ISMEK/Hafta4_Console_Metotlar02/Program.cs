using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Hafta4_Console_Metotlar02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //geriye değer döndüren metotlar --> dönüş tipi olarak float int string.. kullanılır 
            //return ile geri dönüş sağlanır.

            Console.WriteLine(Topla(6, 15));


            Console.Read();
        }

        public static int Topla(int sayi1, int sayi2)  //geriye değer döndüren parametreli 
        {
            int sonuc = sayi1 + sayi2;

            return sonuc;

        }


    }
}
