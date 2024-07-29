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

    }
}
