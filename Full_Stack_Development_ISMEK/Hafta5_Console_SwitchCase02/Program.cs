using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hafta5_Console_SwitchCase02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Tıp Fakültesi için Tıp");
            Console.WriteLine("Sosyal Bilimler Fakültesi için SB");
            Console.WriteLine("Eğitim Fakültesi için Eğitim");

            Console.Write("LÜTFEN FAKÜLTE BİLGİSİNİ GİRİNİZ... ");
            string fakulte = Console.ReadLine();

            switch (fakulte)
            {
                case "Tıp":
                    Console.WriteLine("Genel Cerrah için G");
                    Console.WriteLine("Dahiliye için D");
                    Console.WriteLine("Branşını Seç: ");
                    char brans = Convert.ToChar(Console.ReadLine());

                    switch (brans)
                    {
                        case 'G':
                            Console.WriteLine("Genel Cerrah Bölümüne Giriş Yaptınız...");
                            Console.Write("Yıllık Bölüm Fiyatını Giriniz: ");
                            float yillikFiyat = Convert.ToSingle(Console.ReadLine());

                            Console.WriteLine("Burs Durumu?");
                            Console.WriteLine("1 - Burslu");
                            Console.WriteLine("2 - Burssuz");

                            int durum = Convert.ToInt32(Console.ReadLine());

                            if (durum == 1)
                            {
                                Console.Write("Burs Oranı Giriniz: ");
                                int oran = Convert.ToInt32(Console.ReadLine());

                                float ucret = yillikFiyat * oran / 100;
                                Console.WriteLine("% " + oran + " burslu yıllık tutar " + ucret);

                                Console.WriteLine("Ödeme Peşin ya da Taksit mi Olacak? ");
                                string odeme = Console.ReadLine();

                                if (odeme == "peşin" || odeme == "Peşin" || odeme == "PEŞİN")
                                {

                                }
                                else if (odeme == "taksit" || odeme == "TAKSİT" || odeme == "Taksit")
                                {
                                    Console.WriteLine("Kaç Taksit Olacak? 2 - 4 - 7");
                                    int taksit = Convert.ToInt32(Console.ReadLine());


                                    if (taksit == 2)
                                    {
                                        float aylik = yillikFiyat / taksit;
                                        Console.WriteLine(yillikFiyat + " TL ücreti 2 taksit ile ayda " + aylik + "TL olarak Ödeyebilirsiniz.");
                                    }
                                    else if (taksit == 4)
                                    {
                                        float aylik = yillikFiyat / taksit;
                                        Console.WriteLine(yillikFiyat + " TL ücreti 4 taksit ile ayda " + aylik + "TL olarak Ödeyebilirsiniz.");
                                    }
                                    else if (taksit == 7)
                                    {
                                        float aylik = yillikFiyat / taksit;
                                        Console.WriteLine(yillikFiyat + " TL ücreti 7 taksit ile ayda " + aylik + "TL olarak Ödeyebilirsiniz.");
                                    }
                                    else
                                    {
                                        Console.WriteLine("Hatalı Giriş Yaptınız.");
                                    }
                                }
                            }
                            else
                            {

                                Console.WriteLine("Ödeme Peşin ya da Taksit mi Olacak? ");
                                string odeme = Console.ReadLine();

                                if (odeme == "peşin" || odeme == "Peşin" || odeme == "PEŞİN")
                                {

                                }
                                else if (odeme == "taksit" || odeme == "TAKSİT" || odeme == "Taksit")
                                {
                                    Console.WriteLine("Kaç Taksit Olacak? 2 - 4 - 7");
                                    int taksit = Convert.ToInt32(Console.ReadLine());


                                    if (taksit == 2)
                                    {
                                        float aylik = yillikFiyat / taksit;
                                        Console.WriteLine(yillikFiyat + " TL ücreti 2 taksit ile ayda " + aylik + "TL olarak Ödeyebilirsiniz.");
                                    }
                                    else if (taksit == 4)
                                    {
                                        float aylik = yillikFiyat / taksit;
                                        Console.WriteLine(yillikFiyat + " TL ücreti 4 taksit ile ayda " + aylik + "TL olarak Ödeyebilirsiniz.");
                                    }
                                    else if (taksit == 7)
                                    {
                                        float aylik = yillikFiyat / taksit;
                                        Console.WriteLine(yillikFiyat + " TL ücreti 7 taksit ile ayda " + aylik + "TL olarak Ödeyebilirsiniz.");
                                    }
                                    else
                                    {
                                        Console.WriteLine("Hatalı Giriş Yaptınız.");
                                    }
                                }
                            }
                            break;
                        case 'D':
                            Console.WriteLine("Dahiliye Bölümüne Giriş Yaptınız...");
                            Console.Write("Yıllık Bölüm Fiyatını Giriniz: ");
                            yillikFiyat = Convert.ToSingle(Console.ReadLine());

                            Console.WriteLine("Burs Durumu?");
                            Console.WriteLine("1 - Burslu");
                            Console.WriteLine("2 - Burssuz");

                            durum = Convert.ToInt32(Console.ReadLine());

                            if (durum == 1)
                            {
                                Console.Write("Burs Oranı Giriniz: ");
                                int oran = Convert.ToInt32(Console.ReadLine());

                                float ucret = yillikFiyat * oran / 100;
                                Console.WriteLine("% " + oran + " burslu yıllık tutar " + ucret);

                                Console.WriteLine("Ödeme Peşin ya da Taksit mi Olacak? ");
                                string odeme = Console.ReadLine();

                                if (odeme == "peşin" || odeme == "Peşin" || odeme == "PEŞİN")
                                {

                                }
                                else if (odeme == "taksit" || odeme == "TAKSİT" || odeme == "Taksit")
                                {
                                    Console.WriteLine("Kaç Taksit Olacak? 2 - 4 - 7");
                                    int taksit = Convert.ToInt32(Console.ReadLine());


                                    if (taksit == 2)
                                    {
                                        float aylik = yillikFiyat / taksit;
                                        Console.WriteLine(yillikFiyat + " TL ücreti 2 taksit ile ayda " + aylik + "TL olarak Ödeyebilirsiniz.");
                                    }
                                    else if (taksit == 4)
                                    {
                                        float aylik = yillikFiyat / taksit;
                                        Console.WriteLine(yillikFiyat + " TL ücreti 4 taksit ile ayda " + aylik + "TL olarak Ödeyebilirsiniz.");
                                    }
                                    else if (taksit == 7)
                                    {
                                        float aylik = yillikFiyat / taksit;
                                        Console.WriteLine(yillikFiyat + " TL ücreti 7 taksit ile ayda " + aylik + "TL olarak Ödeyebilirsiniz.");
                                    }
                                    else
                                    {
                                        Console.WriteLine("Hatalı Giriş Yaptınız.");
                                    }
                                }
                            }
                            else
                            {

                                Console.WriteLine("Ödeme Peşin ya da Taksit mi Olacak? ");
                                string odeme = Console.ReadLine();

                                if (odeme == "peşin" || odeme == "Peşin" || odeme == "PEŞİN")
                                {

                                }
                                else if (odeme == "taksit" || odeme == "TAKSİT" || odeme == "Taksit")
                                {
                                    Console.WriteLine("Kaç Taksit Olacak? 2 - 4 - 7");
                                    int taksit = Convert.ToInt32(Console.ReadLine());


                                    if (taksit == 2)
                                    {
                                        float aylik = yillikFiyat / taksit;
                                        Console.WriteLine(yillikFiyat + " TL ücreti 2 taksit ile ayda " + aylik + "TL olarak Ödeyebilirsiniz.");
                                    }
                                    else if (taksit == 4)
                                    {
                                        float aylik = yillikFiyat / taksit;
                                        Console.WriteLine(yillikFiyat + " TL ücreti 4 taksit ile ayda " + aylik + "TL olarak Ödeyebilirsiniz.");
                                    }
                                    else if (taksit == 7)
                                    {
                                        float aylik = yillikFiyat / taksit;
                                        Console.WriteLine(yillikFiyat + " TL ücreti 7 taksit ile ayda " + aylik + "TL olarak Ödeyebilirsiniz.");
                                    }
                                    else
                                    {
                                        Console.WriteLine("Hatalı Giriş Yaptınız.");
                                    }




                                }
                            }
                            break;
                    }
                    break;
                case "SB":
                    Console.WriteLine("İşletme için i");
                    Console.WriteLine("Psikoloji için p");
                    Console.WriteLine("Branş Seçiniz... ");

                    char secim = Convert.ToChar(Console.ReadLine());
                    break;
                case "Eğitim":
                    break;
                default:
                    Console.WriteLine("--------------------------");
                    break;
            }

            Console.Read();

        }
    }
}
