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
            DialogResult r = MessageBox.Show("There are something wrong!", "", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Error);

            if (r == DialogResult.Yes)
            {
                label1.Text = "選擇了Yes";
            }
            else if (r == DialogResult.No)
            {
                label1.Text = "選擇了No";
            }
            else if (r == DialogResult.Cancel)
            {
                label1.Text = "選擇了Cancel";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult r = MessageBox.Show("There are something wrong!", "", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Error);

            if (r == DialogResult.Yes)
            {
                label1.Text = "選擇了Yes";
                return;
            }

            if (r == DialogResult.No)
            {
                label1.Text = "選擇了No";
                return;
            }

            if (r == DialogResult.Cancel)
            {
                label1.Text = "選擇了Cancel";
                return;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DialogResult r = MessageBox.Show("There are something wrong!", "", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);

            if (r == DialogResult.Retry)
            {
                label1.Text = "選擇了Retry";
                return;
            }


            if (r == DialogResult.Cancel)
            {
                label1.Text = "選擇了Cancel";
                return;
            }
        }
    }
}