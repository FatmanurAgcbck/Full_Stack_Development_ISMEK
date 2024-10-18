using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hafta3_Console_Foreach
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //foreach --> sayısal ve metinsel dizi içindeki verileri sırasıyla değişkene atama işlemi yaparak dizi içindeki elemanların hepsini sırasıyla listeleme işlemi yapar

            //Kullanıcının girdiği metindeki sesli harf sayısını bulan program

            string sesliHarf = "aeıioöuü";
            int sayac = 0;

            Console.Write("Bir Metin Giriniz: ");
            string metin = Console.ReadLine();

            foreach(char karakter in metin)
            {
                foreach(char sesli in sesliHarf)
                {
                    if(karakter == sesli)
                    {
                        sayac++;
                    }
                }
            }
            Console.WriteLine();
            Console.WriteLine("Girilen Metin Uzunluğu " + metin.Length);
            Console.WriteLine("Girilen Sesli Metin İçerisindeki Sesli Karakter Sayısı: " + sayac);

            Console.Read();
        }
    }
}
