using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
            textBox1.Clear();

            string input = "";

            if (checkBox1.Checked == true)
            {
                input = input + "蘋果";
            }

            if (checkBox2.Checked == true)
            {
                input = input + "香蕉";
            }

            if (checkBox3.Checked == true)
            {
                input = input + "哈密瓜";
            }


            textBox1.Text = input;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Clear();

            string input = "";

            if (checkBox1.Checked == true)
            {
                input = input + "蘋果" + "\r\n";
            }

            if (checkBox2.Checked == true)
            {
                input = input + "香蕉" + "\r\n";
            }

            if (checkBox3.Checked == true)
            {
                input = input + "哈密瓜" + "\r\n";
            }


            textBox1.Text = input;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Clear();

            string input = "";

            if (checkBox1.Checked == true)
            {
                input = input + "蘋果" + "\r\n";
            }

            if (checkBox2.Checked == true)
            {
                input = input + "香蕉" + "\r\n";
            }

            if (checkBox3.Checked == true)
            {
                input = input + "哈密瓜" + "\r\n";
            }


            textBox1.Text += input;
        }

        //contain  &&  ||
        private void button4_Click(object sender, EventArgs e)
        {
            textBox1.Clear();

            string input = "";

            if (checkBox1.Checked && textBox1.Text.Contains("蘋果") == false)
            {
                input = input + "蘋果" + "\r\n";
            }

            if (checkBox2.Checked && textBox1.Text.Contains("香蕉") == false)
            {
                input = input + "香蕉" + "\r\n";
            }

            if (checkBox3.Checked && textBox1.Text.Contains("哈密瓜") == false)
            {
                input = input + "哈密瓜" + "\r\n";
            }


            textBox1.Text += input;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox1.Clear();

            string input = "";

            if (checkBox1.Checked || checkBox2.Checked)
            {
                input += "便宜" + "\r\n";
            }

            if (checkBox3.Checked)
            {
                input += "好貴" + "\r\n";
            }



            textBox1.Text += input;
        }
    }
}