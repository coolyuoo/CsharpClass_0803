using System;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            comboBox1.Items.Add("框架二"); 
            comboBox1.Items.Add("框架三"); 

        }

        private void comboBox1_TextChanged(object sender, EventArgs e)
        {
            string x = comboBox1.Text;


            if (x == "框架三")
            {
                groupBox3.Visible = true;
                groupBox2.Visible = !groupBox3.Visible;
                return;
            }

            if (x == "框架二")
            {
                groupBox2.Visible = true;
                groupBox3.Visible = !groupBox2.Visible;
                return;
            }

        }
    }
}
