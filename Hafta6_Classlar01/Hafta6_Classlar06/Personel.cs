using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hafta6_Classlar06
{
    internal class Personel
    {
        public string pAd;
        public string pSoyad;
        public int yas;
        private string kimlik;


        public string Kimlik
        {
            
            get
            {

                return kimlik;
            }
            set
            {
               if(value.Length == 11 )
                {
                    kimlik = value;
                }
                else
                {
                    Console.WriteLine("Fazla ya da Eksik Rakam Girdiniz!!");
                }

            }
        }

    }
}
