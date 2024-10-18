using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hafta3_Console_Random03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random rastgele = new Random();

            //int
            //  int sayi = rastgele.Next();  //herhangi bir aralık verilmediği için 0'dan 2.147.483.646 kadar sayı üretir
            //  int sayi = rastgele.Next(50); //0'dan 50'ye kadar olan aralıkta sayı üretir 50 dahil değil
            //  int sayi = rastgele.Next(50,100); // 50 ve 100 aralığında rastgele sayı üretir 50 dahil 100 dahil değil


            //double
            //  double sayi = rastgele.NextDouble(); //0 ve 1 arasında sayı üretir
            // double sayi = rastgele.NextDouble()*100; //0 ve 100 aralığında sayı üretir 100 dahil değil 
          


            //karakter
            //int asci = rastgele.Next(65,91);  //karakterlerin ascı kodları --> 65,91
            //char karakter = Convert.ToChar(asci);
            //Console.WriteLine(karakter);


            //rastgele kelime üretme
            //Random random = new Random();
            //string name = "";
            //for (int i = 0; i < 5; i++)
            //{
            //    char karakter = Convert.ToChar(random.Next(65, 91));
            //    name += karakter;
            //}
            //Console.WriteLine(name);



            //şifre oluturma özel karakter sayı harflernden oluşan 8 karakterli bir random şifre oluşturur

            StringBuilder sb = new StringBuilder(); //birleştirme işlemi yapar yanyana yazdırır buradaki rakamlar ve özel karakterleri stringe çeviriyor 

            for (int i = 0; i < 8; i++)
            {
                int ascii = rastgele.Next(32, 127); //klavyeden yazılabilecek rakam harf ve özel karakterler yer alır --> 32, 127 
                char karakter = Convert.ToChar(ascii);
                sb.Append(karakter); //string builder a ekleme yapar 
            }
            Console.WriteLine(sb.ToString());
            Console.Read();
        }
    }
}
