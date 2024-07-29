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

        private void button1_Click(object sender, EventArgs e)
        {



            bool x = int.TryParse(textBox1.Text, out int v);

            if (x)
            {
                MessageBox.Show(v + "是整數");
            }
            else
            {
                MessageBox.Show(v + "不是整數");
            }


        }

        private void button2_Click(object sender, EventArgs e)
        {


            if (decimal.TryParse(textBox1.Text, out decimal v))
            {

                MessageBox.Show(textBox1.Text + "是浮點數");

            }
            else
            {
                MessageBox.Show(textBox1.Text + "不是浮點數");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {

            //TRUE
            if (bool.TryParse(textBox1.Text, out bool v))
            {

                MessageBox.Show(textBox1.Text + "是布林");

            }
            else
            {
                MessageBox.Show(textBox1.Text + "不是布林");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {

            if (int.TryParse(textBox1.Text, out int v))
            {
                if (v % 2 == 0)
                {
                    MessageBox.Show(v + "是偶整數");
                }
                else
                {
                    MessageBox.Show(v + "不是偶整數");
                }
            }
            else
            {
                MessageBox.Show(v + "不是整數");
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(textBox1.Text, out int v))
            {
                MessageBox.Show(v + "不是整數");
                return;
            }

            if (v % 2 == 1)
            {
                MessageBox.Show(v + "不是偶整數");
                return;
            }


            MessageBox.Show(v + "是偶整數");

        }
    }
}