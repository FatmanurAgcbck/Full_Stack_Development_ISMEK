using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hafta2_Console_Donguler01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //döngü tekrarlayan işlemler için kullanılır
            // Döngü çeşitleri
            // 1-for --> dizi koleksiyon mantığında kullanılır.
            // 2-foreach --> mvc, .net core da listeleme yapar
            // 3-while --> ado.net database den veri alırken kullanılır 
            // 4-do-while 



            //1-For Döngüsü 
            //1 den 10 a kadar olan sayıları yazdır
            //başlangıç noktası int i = 0;
            //bitiş noktası i <= 10
            //artış || azalış i++, i--

            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine(i);
            }



            Console.Read();
        }
    }
}
