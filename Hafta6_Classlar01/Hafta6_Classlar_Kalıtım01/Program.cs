using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hafta6_Classlar_Kalıtım01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //kalıtım(miras) : yapısı gereği diğer sınıflara yol gösteren kendisinden implement edilen diğer sınıfa doldurulması zorunlu bazı özelliklerin aktarılmasını sağlayan yapı

            //ana classtan yavru clasllara kalıtım bırakılarak ana classtaki özelliklerin yavru classlar tarafından da kullanabilmesi sağlanmış olur. 

            Kamyon kamyon1 = new Kamyon();

            kamyon1.kamyonVeriAl();
            kamyon1.KamyonYazdir();

            Otomobil otomobil1 = new Otomobil();

            otomobil1.otoVeriAl();
            otomobil1.OtoYazdir();

        }
    }
}
