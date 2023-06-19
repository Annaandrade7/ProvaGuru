using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GuruDev
{
    public partial class GuruDev : Form
    {

        public GuruDev()
        {
            InitializeComponent();
            lb_resut.Text = " ";
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void bt_canc_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
           

        }

        private void bt_salv_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            int format = comboBox1.SelectedIndex;
            int limp = comboBox1.SelectedIndex;
            int troPe = comboBox1.SelectedIndex;


        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            int dinh = comboBox2.SelectedIndex;
            int pix = comboBox2.SelectedIndex;
            int cart = comboBox2.SelectedIndex;

        }

        private void lb_resut_Click(object sender, EventArgs e)
        {
            Console.WriteLine("");

        }

        public void resultado(int dinh, int pix, int cart, int format, int limp, int troPe)
        {
            try
            {
                format = 100;
                limp = 50;
                troPe = 200;

                dinh = 20 %;
                pix = 10 % ;
                cart = 0;

            }
            catch 
            {
                
            }


        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
