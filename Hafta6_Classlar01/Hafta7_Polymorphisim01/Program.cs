using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hafta7_Polymorphisim01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //2 anahtar kelime
            //--> virtual(sanal) ana classta kullanılıyoruz
            //--> override(ezmek) yan-yavru classlarda kullanılır

            //esneklik, bağlantı ilişkisi azalrma, daha düzenli yazma, okunabilirlik arttırma 

            Turk turk = new Turk();
            turk.SelamVer();

            Ingiliz ing = new Ingiliz();
            ing.SelamVer();

            Console.Read();
        }
    }
}
