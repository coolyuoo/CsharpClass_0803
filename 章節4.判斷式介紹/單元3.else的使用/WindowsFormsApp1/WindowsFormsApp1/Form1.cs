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
            bool a = false;


            if (a == true)
            {
                MessageBox.Show("ok");
            }
            else
            {
                MessageBox.Show("no");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            bool b = 1 == 1;

            if (b == true)
            {
                MessageBox.Show("ok");
            }
            else
            {
                MessageBox.Show("no");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            bool b = 1 != 1;

            if (b == true)
            {
                MessageBox.Show("ok");
            }
            else
            {
                MessageBox.Show("no");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string s = textBox1.Text;

            if ((s == "男") == true)
            {
                MessageBox.Show("正確");
            }
            else
            {
                MessageBox.Show("錯誤");
            }
        }

      

       
    }
}
