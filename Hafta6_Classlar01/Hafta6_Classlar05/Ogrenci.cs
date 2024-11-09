using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hafta6_Classlar05
{
    internal class Ogrenci
    {
        private string ad;
        private string soyad;
        private int yas;
       


        public string Adı
        {
            get;
            set;

        }

        public string Soyadı
        {
            get;
            set;

        }


        public int Yas
        {
            get
            {
                return yas;
                
            }
            set
            {
                if(value < 18)
                {
                    yas = 18;  //18 den küçük değer girilince konsol otomatik olarak onu 18 olarak yazacak girilen değeri yazmayacak
                }
                else
                {
                    yas = value;
                }
            }
        }

    }
}
