using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hafta6_Classlar03
{
    internal class Asker
    {
        public string AdSoyad;
        public string rutbe;
        public string GorevYeri;
        public string KanGrubu;
        public string SaglikDurumu;
        public int yas;


        public void Uyari()
        {
            Console.WriteLine("Nöbet Kazandınız");
        }

        public void Rapor()
        {
            Console.WriteLine("Hastalığınız varsa Cumartesi Revir Günüdür Bilginize...");
        }

    }
}
