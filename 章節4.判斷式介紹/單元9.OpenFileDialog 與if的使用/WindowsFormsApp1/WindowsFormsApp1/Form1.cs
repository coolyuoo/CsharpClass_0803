using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
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
            // 設置描述
            folderBrowserDialog1.Description = "AAAAAA";

            // 設置根文件夾為桌面
            folderBrowserDialog1.RootFolder = Environment.SpecialFolder.Desktop;

            DialogResult result = folderBrowserDialog1.ShowDialog();

            if (result == DialogResult.OK)
            {
                string path = folderBrowserDialog1.SelectedPath;


                // 設置過濾器來允許特定文件類型
                openFileDialog1.Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*";

                //有點無聊 不使用沒關係
                openFileDialog1.FilterIndex = 2; // 預設選擇第一個過濾器

                openFileDialog1.InitialDirectory = path; // 更改為你的初始路徑

                // 如果用戶選擇了一個文件，則顯示其路徑
                openFileDialog1.ShowDialog();



            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // 設置描述
            folderBrowserDialog1.Description = "AAAAAA";

            // 設置根文件夾為桌面
            folderBrowserDialog1.RootFolder = Environment.SpecialFolder.Desktop;

            DialogResult result = folderBrowserDialog1.ShowDialog();

            if (result == DialogResult.OK)
            {
                string path = folderBrowserDialog1.SelectedPath;


                // 設置過濾器來允許特定文件類型
                //openFileDialog1.Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*";

                //有點無聊 不使用沒關係
                openFileDialog1.FilterIndex = 2; // 預設選擇第一個過濾器

                openFileDialog1.InitialDirectory = path; // 更改為你的初始路徑

                // 如果用戶選擇了一個文件，則顯示其路徑
                DialogResult x = openFileDialog1.ShowDialog();

                if (x == DialogResult.OK)
                {
                    string filepath = openFileDialog1.FileName;

                    label2.Text = filepath;

                }



            }

        }

        private void button3_Click(object sender, EventArgs e)
        {

            pictureBox1.Image = Image.FromFile(label2.Text);

        }
    }

}