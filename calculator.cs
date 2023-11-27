using Microsoft.VisualBasic;
using System;
using System.CodeDom;
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
    public partial class calculator : Form
    {
        double result = 0;
        string current_operation = "";
        bool inoperation = false;


        public calculator()
        {
            InitializeComponent();
        }

        private void btn_number(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            inoperation = false;
            if (txt_input.Text == "0" && !inoperation)
            {
                txt_input.Clear();
                txt_input.Text = txt_input.Text + button.Text;
            }

            else
            {
                txt_input.Text = txt_input.Text + button.Text;
            }


        }


        private void btn_C_Click(object sender, EventArgs e)
        {
            result = 0;
            txt_input.Text = "0";
            lbl_result.ResetText();
            current_operation = "";
            inoperation = false;

        }

        private void btn_CE_Click(object sender, EventArgs e)
        {
            txt_input.ResetText();
        }

        private void btn_Remove_Click(object sender, EventArgs e)
        {
            if (txt_input.Text.Length > 0)
            {
                txt_input.Text = txt_input.Text.Remove(txt_input.Text.Length - 1, 1);
            }


        }


        private void dot(object sender, EventArgs e)
        {
            if (!txt_input.Text.Contains(".") && txt_input.Text != "")
            {
                txt_input.Text += ".";
            }
        }

        private void btn_ecual_Click(object sender, EventArgs e)
        {
            try
            {
                switch (current_operation)
                {

                    case "+":



                        result = result + double.Parse(txt_input.Text);
                        break;

                    case "-":

                        result = result - double.Parse(txt_input.Text);
                        break;

                    case "*":
                        if (result == 0)
                        {
                            result = 1;
                        }
                        result = result * double.Parse(txt_input.Text);
                        break;

                    case "/":
                        if (result == 0)
                        {
                            result = 1;
                        }
                        result = result / double.Parse(txt_input.Text);
                        break;
                    case "%":

                        result = result * double.Parse(txt_input.Text) / 100;

                        break;
                    default:
                        result = double.Parse(txt_input.Text);
                        break;

                }
            }
            catch (Exception)
            {

                txt_input.Text = "0";
                btn_ecual.PerformClick();

            }



            txt_input.Text = "0";
            lbl_result.Text = result.ToString();


        }

        private void btn_operations(object sender, EventArgs e)
        {
            Button button = (Button)sender;

            if (!inoperation)
            {

                btn_ecual.PerformClick();
                current_operation = button.Text;



            }
            else
            {
                current_operation = button.Text;

            }
            inoperation = true;
            lbl_result.Text = result.ToString() + " " + current_operation;



        }


    }
}