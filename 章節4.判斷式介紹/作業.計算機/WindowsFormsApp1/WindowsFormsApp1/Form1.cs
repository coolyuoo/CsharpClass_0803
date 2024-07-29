using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {

        long total = 0;
        bool isAdd = false;

        long currentN = 0;//最後步驟

        public Form1()
        {
            InitializeComponent();
        }

        private void button6_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (isAdd)
            {
                textBox1.Clear();
                isAdd = false;
            }

            textBox1.Text += "1";

            currentN = Convert.ToInt64(textBox1.Text);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (isAdd)
            {
                textBox1.Clear();
                isAdd = false;
            }

            textBox1.Text += "2";

            currentN = Convert.ToInt64(textBox1.Text);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (isAdd)
            {
                textBox1.Clear();
                isAdd = false;
            }

            textBox1.Text += "3";

            currentN = Convert.ToInt64(textBox1.Text);

        }

        private void button5_Click(object sender, EventArgs e)
        {
            //作法1
            //total += Convert.ToInt64(textBox1.Text);

            total += currentN;


            isAdd = true;



            //textBox2

            textBox1.Text = total.ToString();


            currentN = 0;
        }
    }

}