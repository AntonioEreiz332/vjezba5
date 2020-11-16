using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tryCatch02
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnPlus_Click(object sender, EventArgs e)
        {
            try
            {
                int a, b, zbroj;
                a = Convert.ToInt32(textBox1.Text);
                b = Convert.ToInt32(txtBrojB.Text);
                zbroj = a + b;
                txtIspis.Text = Convert.ToString(zbroj);
            }
            catch(Exception greska)
            {
                MessageBox.Show(greska.Message, "Pogreška!");
            }
        }
    }
}
