using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hafta1_Console_Degiskenler
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Değişkenler: verileri taşır
            //metinsel veri tipi: string
            //tam sayı: integer (int)
            //ondalıklı sayı: float (10,4f), double(10,4d), decimal(10,4m)
            //tek karakter: char
            //bool true false

            //dışarıdan girilen tüm değerler string olarak alınır
            //diğer değişken türleri ile işlem yapılacaksa tür dönüşümü yapılır(convert ya da parse)
            //convert için;
            //int -> ToInt32
            //char -> ToChar
            //float -> ToSingle
            //decimal -> ToDecimal
            //double -> ToDouble 


            string adSoyad = "Ayla Kale";
            string il = "İstanbul";
            int yas = 40;
            char cinsiyet = 'K';
            string meslek = "Öğretmen";
            float fiyat1 = 1000.6f;
            double fiyat2 = 1000.6d;
            decimal fiyat3 = 1000.6m;




            Console.WriteLine("Adı Soyadı: " + adSoyad);
            Console.WriteLine("İl: " + il);
            Console.WriteLine("Yaş: " + yas);
            Console.WriteLine("Cinsiyet: " + cinsiyet);
            Console.WriteLine("Meslek: " + meslek);
            Console.WriteLine("Meslek: " + meslek);
            Console.WriteLine("Fiyat: " + fiyat1 + " " + fiyat2 + " " + fiyat3);




            Console.ReadLine();
        }
    }
}
