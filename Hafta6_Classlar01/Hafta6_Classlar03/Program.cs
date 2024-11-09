using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hafta6_Classlar03
{
    internal class Program
    {
        static void Main(string[] args)
        {


            Asker asker1 = new Asker();

            Console.Write("Asker Ad Soyad: ");
            asker1.AdSoyad= Console.ReadLine();

            Console.Write("Rütbe Giriniz: ");
            asker1.rutbe = Console.ReadLine();

            Console.Write("Görev Yeri: ");
            asker1.GorevYeri = Console.ReadLine();

            Console.Write("Kan Grubu: ");
            asker1.KanGrubu = Console.ReadLine();

            Console.Write("Sağlık Durumu: ");
            asker1.SaglikDurumu = Console.ReadLine();

            Console.Write("Yaşı: ");
            asker1.yas = Convert.ToInt32(Console.ReadLine());


            Console.Clear();

            Console.WriteLine("ANA EKRAN");
            Console.WriteLine("Ad Soyad: " + asker1.AdSoyad);
            Console.WriteLine("Rütbe: " + asker1.rutbe);
            Console.WriteLine("Görev Yeri: " + asker1.GorevYeri);
            Console.WriteLine("Kan Grubu: " + asker1.KanGrubu);
            Console.WriteLine("Sağlık Durumu: " + asker1.SaglikDurumu);
            Console.WriteLine("Yaşı: " + asker1.yas);


            asker1.Uyari();
            asker1.Rapor();

            Console.Read();
        }
    }
}
