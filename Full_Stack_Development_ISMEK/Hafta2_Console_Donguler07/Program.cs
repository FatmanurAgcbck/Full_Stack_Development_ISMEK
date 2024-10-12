using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hafta2_Console_Donguler07
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //başlangıç ve bitiş sayısının belirleyiniz ve bu sayıların arasındaki 3 ve 5 e bölünenlerin adedini bulduran program

            Console.Write("Başlangıç değerini giriniz: ");
            int baslangic = Convert.ToInt32(Console.ReadLine());

            Console.Write("Bitiş değerini giriniz: ");
            int bitis = Convert.ToInt32(Console.ReadLine());

            int adet = 0;
            Console.WriteLine();


            for (int i = baslangic; i < bitis; i++)
            {
                if (i % 3 == 0 && i % 5 == 0)
                {

                    Console.WriteLine(i + " bölünür");
                    adet++;
                }
            }
            Console.WriteLine();
            Console.WriteLine("3 ve 5 e bölünen sayıların adedi: " + adet);

            Console.Read();



        }
    }
}
