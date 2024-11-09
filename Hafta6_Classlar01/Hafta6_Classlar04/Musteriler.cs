using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hafta6_Classlar04
{
    internal class Musteriler
    {
        private int mno;
        private string madres;
        float bakiye;


        public int Mno
        {
            get { return mno; }
            set
            {
                if (value > 2 && value < 100)
                {
                    mno = value;
                }
                else
                {
                    Console.WriteLine("2 ile 100 arasında bir değer girmeniz gerekiyor!!");
                }
            }
        }




        public string MAdres
        {
            get;
            set;

        }


        public float Bakiye
        {
            get 
            { 
                return bakiye; 
            }
            set
            {
                if (value > 1000 && value < 2000)
                {
                    bakiye = value;
                }
                else
                {
                    Console.WriteLine("Bakiyeniz Düşük!!");
                }
            }



        }
    }
}

