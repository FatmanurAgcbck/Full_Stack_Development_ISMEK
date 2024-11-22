using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hafta7_Form02
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void hesapla_Click(object sender, EventArgs e)
        {
            int sayi1 = Convert.ToInt32(textBox1.Text);
            int sayi2 = Convert.ToInt32(textBox2.Text);
            string islem = textBox3.Text;

            if (islem == "+")
            {
                label4.Text = "Toplama Sonucu: ";
                int toplam = sayi1 + sayi2;
                label5.Text = toplam.ToString();
            }
            else if (islem=="-")
            {
                label4.Text = "Çıkarma Sonucu: "; 
                int fark = sayi1 - sayi2;
                label5.Text = fark.ToString();
            }
            else if (islem == "*")
            {
                label4.Text = "Çarpma Sonucu: ";
                int carp = sayi1 * sayi2;
                label5.Text = carp.ToString();
            }
            else if(islem == "/") 
            {
                label4.Text = "Bölme Sonucu: ";
                int bol = sayi1/sayi2;
                label5.Text = bol.ToString();
            }
            else
            {
                MessageBox.Show("Sadece 4 İşlem Yapılır!");
            }

        }
    }
}
