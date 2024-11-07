using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hafta5_Console_SwitchCase
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //switch case --> karar kontrol yapısı. tanımlanmış olan yalnızca bir değişkenin, alacağı değerlere bağlı olarak farklı sonuclar döndürmesini sağlayan yapılar
            //if else den farkı şart kısmında ve veya kullanılamıyor olması


            //şehir isimleri belirlensin ve secilen şehirlere göre de ilçe isimleri yazılsın

            Console.WriteLine("1 - İstanbul ");
            Console.WriteLine("2 - Ankara ");
            Console.WriteLine("3 - İzmir ");
            Console.WriteLine("4 - Edirne ");

            Console.Write("HANGİ ŞEHİR YAZINIZ ");
            int sehir = Convert.ToInt32(Console.ReadLine());


            switch (sehir)
            {
                case 1:
                    Console.WriteLine("İlçeleri: Kartal, Maltepe");
                    break;
                case 2:
                    Console.WriteLine("İlçeleri: Mamak, Çankaya");
                    break;
                case 3:
                    Console.WriteLine("İlçeleri: Foça, Konak");
                    break;
                case 4:
                    Console.WriteLine("İlçeleri: Havsa, Meriç");
                    break;  

                default:
                    Console.WriteLine("Yanlış Giriş Yaptınız. Girmiş Olduğunuz İl Bİlgisi Bulunmamaktadır.");
                    break;
            }



            Console.Read();



        }
    }
}
