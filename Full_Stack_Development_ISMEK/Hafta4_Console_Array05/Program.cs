using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hafta4_Console_Array05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //kullanıcıdan kullanıcı adı ve şifre istensin. kullanıcı adı doğru ise şifreyi soracak. sonra hoşgeldiniz yazsın
            //şifre yanlış ise girilen bilgiler hatalı kullanıcıdan tekrar kullanıcı adı ve şifre istensin


            go2:
            Console.Write("Kullanıcı Adınızı Giriniz: ");
            string kullaniciAdi = Console.ReadLine();
           
            
            if (kullaniciAdi == "Nur")
            {
                go:
                Console.Write("Şifreyi Giriniz: ");
                string sifre =  Console.ReadLine();
                

                
                if (sifre == "1234")
                {
                    Console.WriteLine("HOŞGELDİNİZ");
                }
                else
                {
                    Console.WriteLine("Şifre Hatalı");
                go3:
                    Console.WriteLine("Tekrar Denemek İster Misiniz? E/H ");
                    char deneme = Convert.ToChar(Console.ReadLine());
                    
                    if(deneme == 'e' ||  deneme == 'E')
                    {
                        Console.Clear();
                        goto go;
                    }
                    else if (deneme == 'h' || deneme == 'H')
                    {
                        Console.WriteLine("Çıkış Yapmak İçin Enter Tuşuna Basın...");
                    }
                    else
                    {
                        Console.WriteLine("Hatalı Karakter Girişi.");
                        goto go3;
                    }
                    
                }
                
            }
            else
            {
                Console.WriteLine("Kullanıcı Adı Hatalı!");
                go4:
                Console.WriteLine("Tekrar Denemek İster Misiniz? E/H ");
                char deneme = Convert.ToChar(Console.ReadLine());
                if (deneme == 'e' || deneme == 'E')
                {
                    Console.Clear();
                    goto go2;
                }
                else if (deneme == 'h' || deneme == 'H')
                {
                    Console.WriteLine("Çıkış Yapmak İçin Enter Tuşuna Basın...");
                }
                else
                {
                    Console.WriteLine("Hatalı Karakter Girişi.");
                    goto go4;
                }
            }

            Console.Read();

        }
    }
}
