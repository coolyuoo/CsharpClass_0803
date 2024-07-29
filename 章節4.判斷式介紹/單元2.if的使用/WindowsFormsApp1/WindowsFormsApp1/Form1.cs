using System;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }





        private void button5_Click(object sender, EventArgs e)
        {
            int i = 12;

            if (i == 13)
            {
                i = i + 1;
            }

            MessageBox.Show(i.ToString());
        }

        private void button4_Click(object sender, EventArgs e)
        {
            decimal panCount = numericUpDown1.Value;

            //要做帳 如果筆的數量少於18個 數量加5
            if (panCount < 18)
            {
                panCount = panCount + 5;
            }



            MessageBox.Show(panCount.ToString());

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            int panCount = 12;

            //要做帳 如果筆的數量少於18個 數量加5
            if (panCount < 18)
            {
                panCount = panCount + 5;
            }



            MessageBox.Show(panCount.ToString());

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string car = "車子改裝:";


            if (textBox1.Text != "")
            {
                car = car + textBox1.Text;
            }



            MessageBox.Show(car);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            decimal en = q3_1.Value;
            decimal math = q3_2.Value;

            string msg = "不及格";

            if (en >= 60 && math >= 60)
            {
                msg = "及格";
            }



            MessageBox.Show(msg.ToString());
        }

        private void button6_Click(object sender, EventArgs e)
        {
            decimal en = q4_1.Value;
            decimal math = q4_2.Value;

            string msg = "不及格";

            if (en >= 60 || math >= 60)
            {
                msg = "及格";
            }



            MessageBox.Show(msg.ToString());
        }
    }
}
