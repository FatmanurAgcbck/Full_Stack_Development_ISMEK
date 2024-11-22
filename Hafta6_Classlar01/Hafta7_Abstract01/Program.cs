using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hafta7_Abstract01
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Kanepe knp = new Kanepe();
            knp.renk = "Beyaz";
            knp.kumas = "Kadife";

            knp.Ozellikler();


            Console.Read();
        }
    }
}
