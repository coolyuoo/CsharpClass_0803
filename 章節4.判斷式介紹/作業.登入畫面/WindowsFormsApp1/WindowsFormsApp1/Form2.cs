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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();

            textBox2.PasswordChar = '*';
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string x = textBox1.Text.ToUpper();


            if (x == "ABC" && textBox2.Text == "123")
            {
                // 創建 Form1 的實例
                Form1 f1 = new Form1();

                // 顯示 Form1
                f1.Show();


                this.Hide();    
            }
            else
            {

                MessageBox.Show("帳密錯誤");
            }


        }
    }
}
