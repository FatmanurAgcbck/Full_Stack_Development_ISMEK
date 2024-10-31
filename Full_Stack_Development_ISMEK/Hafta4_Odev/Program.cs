using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Authentication.ExtendedProtection.Configuration;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace Hafta4_Odev
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
           
            
        go:
            //kullanıcı bilgileri isteme
            Console.Write("Lütfen Kullanıcı Adını Giriniz: ");
            string kullaniciAd = Console.ReadLine();

            Console.Write("Lütfen Şifrenizi Giriniz: ");
            string sifre = Console.ReadLine();
            Console.WriteLine("-------------------------------------");

            //kullanıcı bilgileri kontrol
            if (kullaniciAd == "Nur" & sifre == "1234")
            {
                Console.WriteLine("Kullanıcı Girişi Başarılı.");
                Console.WriteLine();

                Console.Write("Yaşınızı Girin: ");
                int yas = int.Parse(Console.ReadLine());
                Console.WriteLine();

                Console.Write("Prim Gününüzü Girin: ");
                int prim = int.Parse(Console.ReadLine());
                Console.WriteLine();

                //yaş 40 ve üzeri prim 5000 ve üzeri
                if (yas >= 40 && prim >= 5000)
                {
                    Console.WriteLine("Emekli Olmaya Hak Kazandınız.");
                    Console.WriteLine("-------------------------------------");
                    Console.WriteLine();

                    Console.Write("Maaşınızı Giriniz: ");
                    double maas = double.Parse(Console.ReadLine());

                    Console.Write("Kaç Yıl Çalıştınız? ");
                    int sene = int.Parse(Console.ReadLine());

                    //sene 20 ve üzeri
                    if (sene >= 20)
                    {
                        double ikramiye = (maas * sene) * 775 / 100;
                        Console.WriteLine("İkramiyeniz: " + ikramiye);
                        Console.WriteLine("----------------------------------------");
                        Console.WriteLine();
                    }
                    else if (sene < 20) //sene 20 altı
                    {
                        double ikramiye = (maas * sene) * 505 / 100;
                        Console.WriteLine("İkramiyeniz: " + ikramiye);
                        Console.WriteLine("----------------------------------------");
                        Console.WriteLine();
                    }
                                       
                }
                //yaş 40 altı ve prim 5000 altı olanlar
                else
                {
                    //kalan prim hesabı 
                    int kalanGun = 0;
                    kalanGun = 5000 - prim;
                    Console.WriteLine("Kalan Gün Sayınız: " + kalanGun);
                    Console.WriteLine();

                    //borç ödeme seçeneği
                    go3:
                    Console.Write("Prim Günleri İçin Borç Günü Ödemek İster Misiniz ? E / H ");
                    char secenek = char.Parse(Console.ReadLine());
                    Console.WriteLine("----------------------------------------");

                    if (secenek == 'e' || secenek == 'E')
                    {
                        double borc = 50000 / 5;
                        Console.WriteLine("Toplam Borcunuz 50000 TL.");
                        Console.WriteLine($"Borcunuzu 5 Taksit Şeklinde Ayda {borc} TL Olarak Ödeyebilirsiniz. ");
                    }
                    else if(secenek == 'h' ||secenek == 'H')
                    {
                        Console.WriteLine("Çıkış Yapmak İçin Enter Tuşuna Basınız!");
                    }
                    else
                    {
                        Console.WriteLine("Hatalı Karakter Girişi Yaptınız");
                        Console.WriteLine();
                        goto go3;
                    }
                }
            }            
            //hatalı kullanıcı girişi kontrolü
            else
            {
                Console.WriteLine("Kullanıcı Bilgileriniz Yanlış!");
                Console.Write("Tekrar Giriş Yapmak İster Misiniz? E / H");
                Console.WriteLine();

                go2:
                char deneme = char.Parse(Console.ReadLine());

                if(deneme == 'e' || deneme == 'E')
                {
                    Console.Clear();
                    goto go; //tekrar giriş yapmak isterse kullanıcı adı ve şifre istemeye dönecek
                }
                else if (deneme == 'h' || deneme == 'H')
                {
                    Console.WriteLine();
                    Console.WriteLine("Çıkış Yapmak İçin Enter Tuşuna Basınız!");
                } 
                else
                {
                    Console.WriteLine("Hatalı Karakter Girişi Yaptınız");
                    Console.WriteLine("Tekrar Deneyin E / H ");
                    goto go2;
                }
                
            }



            Console.Read();
        }
    }
}
