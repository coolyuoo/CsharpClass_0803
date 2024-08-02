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

      
        private void button5_Click(object sender, EventArgs e)
        {
            decimal d = numericUpDown1.Value;


            //if (d == 100)
            //{
            //    MessageBox.Show("very good");
            //}
            //else if (d > 80)
            //{
            //    MessageBox.Show("good");
            //}
            //else if (d > 60)
            //{
            //    MessageBox.Show("soso");
            //}
            //else 
            //{
            //    MessageBox.Show("bad~");
            //}


            //過關的概念
            if (d == 100)
            {
                MessageBox.Show("very good");
                return;
            }

            if (d > 80)
            {
                MessageBox.Show("good");
                return;
            }

            if (d > 60)
            {
                MessageBox.Show("soso");
                return;
            }

            MessageBox.Show("bad~");


        }

        private void button1_Click(object sender, EventArgs e)
        {
            //從小到大
            decimal d = numericUpDown1.Value;


            if (d < 60)
            {
                MessageBox.Show("bad~");
            }
            else if (d >= 60 && d < 80)
            {
                MessageBox.Show("soso");

            }
            else if (d >= 80 && d < 100)
            {
                MessageBox.Show("good");
            }
            else
            {
                MessageBox.Show("very good");
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            //比第一種好 少寫一些(從大到小)

            decimal d = numericUpDown1.Value;


            if (d == 100)
            {
                MessageBox.Show("very good");
            }
            else if (d >= 80)
            {
                MessageBox.Show("good");
            }
            else if (d >= 60)
            {
                MessageBox.Show("soso");
            }
            else
            {
                MessageBox.Show("bad~");
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            //不推薦 會全部跑完

            decimal d = numericUpDown1.Value;


            if (d == 100)
            {
                MessageBox.Show("very good");
            }

            if (d < 100 && d >= 80)
            {
                MessageBox.Show("good");
            }

            if (d < 80 && d >= 60)
            {
                MessageBox.Show("soso");
            }

            if (d < 60)
            {
                MessageBox.Show("bad~");
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            decimal d = numericUpDown1.Value;


            if (d == 100)
            {
                MessageBox.Show("very good");

                return;
            }

            if (d >= 80)
            {
                MessageBox.Show("good");

                return;
            }

            if (d >= 60)
            {
                MessageBox.Show("soso");

                return;
            }


            MessageBox.Show("bad~");

        }
    }
}
