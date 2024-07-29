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
            // 設置描述
            folderBrowserDialog1.Description = "AAAAAA";

            // 設置根文件夾為桌面
            folderBrowserDialog1.RootFolder = Environment.SpecialFolder.Desktop;

            DialogResult result = folderBrowserDialog1.ShowDialog();

            if (result == DialogResult.OK)
            {
                label1.Text = folderBrowserDialog1.SelectedPath;
            }


        }
    }

}