using System;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {

        decimal total = 0;
        bool isAction = false;
        bool start = false;
        decimal currentN = 0;//最後步驟

        string tag = "";

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (start == false)
            {
                textBox1.Clear();
                start = true;
            }

            if (isAction)
            {
                textBox1.Clear();
                isAction = false;
            }

            textBox1.Text += ((Button)sender).Text;

            currentN = Convert.ToInt64(textBox1.Text);

            if (total == 0)
            {
                total = currentN;
            }
            else
            {
                if (tag == "+")
                {
                    total += currentN;
                }
                else if (tag == "-")
                {
                    total -= currentN;
                }
                else if (tag == "x")
                {
                    total *= currentN;
                }
                else if (tag == "/")
                {
                    total /= currentN;
                }
            }

        }




        private void button5_Click(object sender, EventArgs e)
        {
            if (((Button)sender).Text != "=")
            {
                tag = ((Button)sender).Text;
            }

            isAction = true;
            textBox1.Text = total.ToString();
            currentN = 0;
        }


        private void button4_Click(object sender, EventArgs e)
        {
            textBox1.Text = "0";
            currentN = 0;
            total = 0;
            start = false;
            tag = "";
        }

        private void button17_Click(object sender, EventArgs e)
        {

        }
    }

}