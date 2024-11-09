using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hafta6_Classlar07
{
    internal class Ogrenciler
    {
        string tcNo;
        string ogrenciNo;
        public string adSoyad;
        int not;
        public int burs;



        public string TcNo
        {
            get
            {
                return tcNo;
            }
            set
            {
                if (value.Length==11)
                {
                    tcNo = value;
                }
                else
                {
                    Console.WriteLine("TC No 11 Haneli Olarak Girilmedi!!");
                    Console.Write("TC No Giriniz: ");
                    TcNo = Console.ReadLine();
                }
            }
        }

        public string OgrenciNo
        {
            get
            {
                return ogrenciNo;
            }
            set
            {
                if(value.Length==4)
                {
                    ogrenciNo = value;
                }
                else
                {
                    Console.WriteLine("Öğrenci Numarası 4 Haneli Girilmeli!");
                    Console.Write("Öğrenci Numarası Giriniz: ");
                    OgrenciNo = Console.ReadLine();
                }
            }
        }

        public int Not
        {
            get
            {
                return not;
            }
            set
            {
                if(value > 0 && value < 100)
                {
                    not = value;
                }
                else
                {
                    Console.WriteLine("Yanlış Giriş!! Girilen Değer 0 - 100 arasında olmalıdır.");
                    Console.WriteLine("Not Giriniz: ");
                    Not = int.Parse(Console.ReadLine());
                }
            }
        }

        public int BursVer(int not, int burs)
        {
            if( not >= 80 && not <= 100)
            {
                burs += 5000;
                return burs;
            }
            else
            {
                return burs;
            }
        }

        public void Hediye(int totalBurs)
        {
            if (totalBurs > 7500)
            {
                Console.WriteLine("Bilgisayar Kazandınız :)");
            }
            else
            {
                Console.WriteLine("Tablet Kazandınız :)");
            }
        }


    }
}
