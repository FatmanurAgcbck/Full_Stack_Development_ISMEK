using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hafta7_Abstract01
{
    internal class Kanepe:Mobilya
    {
        public string kumas;

        public override void Ozellikler()
        {
            Console.WriteLine("Kanepenin Özellikleri");
            Console.WriteLine("Renk: " + renk);
            Console.WriteLine("Kumaş: " + kumas);
        }
    }
}
