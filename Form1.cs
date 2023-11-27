using System.Linq.Expressions;

namespace temp_converter
{
    public partial class Form1 : Form
    {
        float fehren ;
        float celesus ;
        float kalven ;

        public Form1()
        {

            InitializeComponent();

        }
      
        private void Btn_fehren_Click(object sender, EventArgs e)
        {
            try
            {
                fehren = float.Parse(Txt_fehren.Text);
            }
            catch 
            {

                MessageBox.Show("only numbers can be converted");
               
            }
            
            celesus = ( fehren - 32f) * 5f / 9;
            Txt_celesus.Text = celesus.ToString();
            kalven = celesus + 273.15f;
            Txt_kalven.Text = kalven.ToString();
        }


        private void Btn_celesus_Click(object sender, EventArgs e)
        {
            try
            {
                celesus = float.Parse(Txt_celesus.Text);
            }
            catch
            {

                MessageBox.Show("only numbers can be converted");
            }
            kalven = celesus + 273.15f;
            Txt_kalven.Text = kalven.ToString();
            fehren = (celesus * 9f / 5f) + 32f;
            Txt_fehren.Text = fehren.ToString();

        }

        private void Btn_kalven_Click(object sender, EventArgs e)
        {
            try
            {
                kalven = float.Parse(Txt_kalven.Text);
            }
            catch
            {

                MessageBox.Show("only numbers can be converted");
            }
            celesus = kalven - 273.15f;
            Txt_celesus.Text = celesus.ToString();
            fehren = (kalven - 273.15f) * 9f / 5f + 32f;
            Txt_fehren.Text = fehren.ToString();
        }

  
    }
}