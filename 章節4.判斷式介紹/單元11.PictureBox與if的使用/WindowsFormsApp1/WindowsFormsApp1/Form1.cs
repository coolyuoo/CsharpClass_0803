using System;
using System.Drawing;
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
            Random random = new Random();

            int x = random.Next(1, 7);

            string imgPath = @"D:\\CodeProject\\線下教學\\student\\C# Basic Tutorial Course File\\章節4.判斷式介紹\\temp\\dice\\{0}.png";


            if (x == 1)
            {
                imgPath = string.Format(imgPath, 1);
            }
            else if (x == 2)
            {
                imgPath = string.Format(imgPath, 2);
            }
            else if (x == 3)
            {
                imgPath = string.Format(imgPath, 3);
            }
            else if (x == 4)
            {
                imgPath = string.Format(imgPath, 4);
            }
            else if (x == 5)
            {
                imgPath = string.Format(imgPath, 5);
            }
            else
            {
                imgPath = string.Format(imgPath, 6);
            }


            Image i= Image.FromFile(imgPath);

            pictureBox1.Image = i;

            button1.Text = x.ToString();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Random random = new Random();

            int x = random.Next(1, 7);

            string imgPath = @"D:\\CodeProject\\線下教學\\student\\C# Basic Tutorial Course File\\章節4.判斷式介紹\\temp\\dice\\{0}.png";

            imgPath = string.Format(imgPath, x);
            
            pictureBox1.Image = Image.FromFile(imgPath);

            button2.Text = x.ToString();
        }
    }
}