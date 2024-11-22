using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hafta7_Form03
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void kaydet_Click(object sender, EventArgs e)
        {
            if (evli.Checked)
            {
                listBox1.Items.Add("Medeni Durumu: " + evli.Text);
            }
            else
            {
                listBox1.Items.Add("Medeni Durumu: " + bekar.Text);
            }

            if (a.Checked == true  )
            {
                listBox1.Items.Add("Ehliyet Sınıfı: " + a.Text);
            }
            if (b.Checked==true)
            {
                listBox1.Items.Add("Ehliyet Sınıfı: " + b.Text);
            }

        }
    }
}
