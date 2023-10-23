using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace for_1__96
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            string ad = txtAd.Text;
  
            for(int i = 0; i < 10; i++) //"i++" birer birer arttırmak.
            {
                string metin = i.ToString() + " - " + ad;
                lbAd.Items.Add(metin);

            }
        }
    }
}
