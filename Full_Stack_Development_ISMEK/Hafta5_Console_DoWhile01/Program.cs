using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hafta5_Console_DoWhile01
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //Do-While döngüsü --> koşulun doğru olup olmadığını kontrol etmeden önce kod bloğunu bir kez çalıştıran ve ardından koşul doğru olduğu sürece döngüyü tekrarlar 
            //kaç kez çalışacağı belli olmayan, koşulun bir girdiye göre denetlendiği durumlarda kullanılır7
            //Tekrar sayısı belli olan durumlarda (diziler gibi) for döngüsü kullanılır 

            int sayi = 0;

            do
            {
                Console.WriteLine("Sayı değişkeninin değeri: " + sayi);
                sayi++;
            }
            while (sayi < 10);
            

            Console.Read();

        }
    }
}
