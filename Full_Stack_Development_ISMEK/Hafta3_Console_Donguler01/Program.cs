using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hafta3_Console_Donguler01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //klavyeden çalışan sayısı girilsin. sırasıyla çalışanların maaşı da istensin. Eğer maaş 8 bin ile 16 bin arasındayda kaç yıldır çalıştığı sorulsun.Eğer 5 ile 10 yıl arasında çalışıyor ise 2000 ile 5000 arasında random mesai ücreti atansın ve toplam maaşa eklenerek maaş gösterilsin

            //yıl şartı uymuyorsa maaşa 2000 ile 3000 arasında random değer atayarak maaş ile toplansın

            //maaş 8 ile 16 bin arasında değilse maaşa 1000 bile 2000 arasında random değer atayarak maaş ile toplansın

            //en sonunda tüm çalışanların toplam maaş ve mesai ücretleri toplamını gösteren program


            Console.Write("Çalışan Sayısını Giriniz: ");
            int calisanSayisi = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();

            Random rastgele = new Random();
            int toplamMaas = 0;
            int toplamMesai = 0;

            for (int i = 1; i <= calisanSayisi; i++)
            {
                Console.Write(i + ". çalışanın maaşını giriniz: ");
                int maas = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine();


                if (maas >= 8000 && maas <= 18000)
                {
                    Console.Write("Kaç senedir çalışıyor?  ");
                    int sene = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine();

                    if (sene >= 5 && sene <= 10)
                    {
                        int mesai = rastgele.Next(2000, 5001);
                        maas += mesai;
                        Console.WriteLine(i + ". Çalısanın Mesai Ücreti " + mesai);
                        Console.WriteLine(i + ". Çalışanın Toplam Maaşı " + maas);                     
                        Console.WriteLine();
                        toplamMaas += maas;
                        toplamMesai += mesai;
                    }
                    else
                    {
                        int mesai = rastgele.Next(2000, 3001);
                        maas += mesai;
                        Console.WriteLine(i + ". Çalısanın Mesai Ücreti " + mesai);
                        Console.WriteLine(i + ". Çalışanın Toplam Maaşı " + maas);
                        Console.WriteLine();
                        toplamMaas += maas;
                        toplamMesai += mesai;
                    }
                }
                else
                {
                    int mesai = rastgele.Next(1000, 2001);
                    maas += mesai;
                    Console.WriteLine(i + ". Çalısanın Mesai Ücreti " + mesai);
                    Console.WriteLine(i + ". Çalışanın Toplam Maaşı " + maas);
                    Console.WriteLine();
                    toplamMaas += maas;
                    toplamMesai += mesai;
                }
                Console.WriteLine("--------------------------------------------------------");
            }

            Console.WriteLine();
            Console.WriteLine("Tüm Çalışanların Toplam Maaşı: " + toplamMaas);
            Console.WriteLine("Tüm Çalışanların Toplam Mesai Ücreti: " + toplamMesai);

            Console.Read();
        }
    }
}
