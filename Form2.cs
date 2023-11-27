using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace temp_converter
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Btn_temp_app_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 form = new Form1();
            form.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void btn_Calculater_Click(object sender, EventArgs e)
        {
            this.Hide();
            calculator form = new calculator();
            form.ShowDialog();
        }
    }
}
