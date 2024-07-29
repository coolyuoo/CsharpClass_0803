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
        public Form1()
        {
            InitializeComponent();


            //-----

            comboBox3.Items.Add("國中");
            comboBox3.Items.Add("高中");
            comboBox3.Items.Add("大學");
            comboBox3.Items.Add("研所");


            comboBox3.DropDownStyle = ComboBoxStyle.DropDownList;


            comboBox3.SelectedItem = "國中";



        }



        private void button2_Click(object sender, EventArgs e)
        {
            string all = "";

            string t = comboBox3.Text;

            all += t + "\r\n";

            all += "你擅長的技術是:" + "\r\n";

            if (checkBox1.Checked == true)
            {
                all = all + checkBox1.Text + "\r\n";
            }

            if (checkBox2.Checked == true)
            {
                all = all + checkBox2.Text + "\r\n";
            }

            if (checkBox3.Checked)
            {
                all = all + checkBox3.Text + "\r\n"; ;
            }

            if (checkBox4.Checked)
            {
                all = all + checkBox4.Text + "\r\n";
            }

            all = all + "你的居住地:" + "\r\n";
            
            if (radioButton9.Checked)
            {
                all = all + radioButton9.Text + "\r\n";
            }
            else if (radioButton8.Checked)
            {
                all = all + radioButton8.Text + "\r\n";
            }
            else if (radioButton7.Checked)
            {
                all = all + radioButton7.Text + "\r\n";
            }





            MessageBox.Show(all);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked == false || !checkBox2.Checked || checkBox3.Checked == false || !checkBox4.Checked)
            {
                MessageBox.Show("請至少選擇一個技術");
            }


            string all = "";

            string t = comboBox3.Text;

            all += t + "\r\n";

            all += "你擅長的技術是:" + "\r\n";

            if (checkBox1.Checked == true)
            {
                all = all + checkBox1.Text + "\r\n";
            }

            if (checkBox2.Checked == true)
            {
                all = all + checkBox2.Text + "\r\n";
            }

            if (checkBox3.Checked)
            {
                all = all + checkBox3.Text + "\r\n"; ;
            }

            if (checkBox4.Checked)
            {
                all = all + checkBox4.Text + "\r\n";
            }


            MessageBox.Show(all);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked == false && !checkBox2.Checked && checkBox3.Checked == false && !checkBox4.Checked)
            {
                MessageBox.Show("請至少選擇一個技術");
                //return;
            }
            else
            {


                string all = "";

                string t = comboBox3.Text;

                all += t + "\r\n";

                all += "你擅長的技術是:" + "\r\n";

                if (checkBox1.Checked == true)
                {
                    all = all + checkBox1.Text + "\r\n";
                }

                if (checkBox2.Checked == true)
                {
                    all = all + checkBox2.Text + "\r\n";
                }

                if (checkBox3.Checked)
                {
                    all = all + checkBox3.Text + "\r\n"; ;
                }

                if (checkBox4.Checked)
                {
                    all = all + checkBox4.Text + "\r\n";
                }


                MessageBox.Show(all);
            }
        }

       
    }

}