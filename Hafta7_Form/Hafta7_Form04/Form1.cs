using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hafta7_Form04
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            lbFatura.Items.Add("*************FATURA*************");
        }


        private void SatinAl_Click(object sender, EventArgs e)
        {
            lbFatura.Visible = true;
           

        }
        private void cmbKahve_SelectedIndexChanged(object sender, EventArgs e)
        {
            string kahveSec = cmbKahve.SelectedItem.ToString();
            

            if (kahveSec == "Filtre")
            {
                gbFiltre.Visible = true;
                SatinAl.Visible = true;
                txtFiltFiyat.Text = "75 TL";               
                lbFatura.Items.Add(txtFiltFiyat.Text);

            }
            else if(kahveSec == "Türk Kahvesi")
            {
                gbTurkKah.Visible = true;
                SatinAl.Visible = true;
                txtTkFiyat.Text = "45 TL";
                lbFatura.Items.Add(txtTkFiyat.Text);
            }
            else if (kahveSec =="Latte")
            {
                gbLatte.Visible = true;
                SatinAl.Visible = true;
                txtLatFiyat.Text = "95 TL";
                lbFatura.Items.Add(txtLatFiyat.Text);
            }
            
        }

        
    }
}
