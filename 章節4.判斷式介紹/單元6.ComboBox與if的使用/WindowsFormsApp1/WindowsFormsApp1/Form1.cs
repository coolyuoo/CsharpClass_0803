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

            comboBox1.Items.Add("葬送的芙莉蓮");
            comboBox1.Items.Add("鬼滅之刃柱訓練篇");
            comboBox1.Items.Add("海賊王");
            comboBox1.Items.Add("怪獸8號");


            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;


            comboBox1.SelectedItem = "葬送的芙莉蓮";

            //-----

            comboBox2.Items.Add("葬送的芙莉蓮");
            comboBox2.Items.Add("鬼滅之刃柱訓練篇");
            comboBox2.Items.Add("海賊王");
            comboBox2.Items.Add("怪獸8號");


            comboBox2.DropDownStyle = ComboBoxStyle.DropDownList;


            comboBox2.SelectedItem = "葬送的芙莉蓮";

            //-----

            comboBox3.Items.Add("國中");
            comboBox3.Items.Add("高中");
            comboBox3.Items.Add("大學");
            comboBox3.Items.Add("研所");


            comboBox3.DropDownStyle = ComboBoxStyle.DropDownList;


            comboBox3.SelectedItem = "國中";

            //-------

            comboBox4.Items.Add("按鈕1");
            comboBox4.Items.Add("按鈕2");
            comboBox4.Items.Add("按鈕3");
            comboBox4.Items.Add("按鈕4");
                    
                    
            comboBox4.DropDownStyle = ComboBoxStyle.DropDownList;
                    
                    
            comboBox4.SelectedItem = "";

            //------
            button5.Visible = false;
            button6.Visible = false;
            button7.Visible = false;
            button8.Visible = false;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBox1.Text == "葬送的芙莉蓮")
            {
                textBox1.Text = "故事背景設定於存在著魔法與奇幻生物的虛構世界，" +
                    "講述勇者一行人打倒魔王之後，" +
                    "勇者一行人中精靈魔法使芙莉蓮的故事。";

                return;
            }

            if (comboBox1.Text == "鬼滅之刃柱訓練篇")
            {
                textBox1.Text = "2024年3月9日，官方宣布《柱訓練篇》將於2024年5月12日正式播出，" +
                    "並且釋出正式預告片";

                return;
            }

            if (comboBox1.Text == "海賊王")
            {
                textBox1.Text = "作品以虛構的「大海賊時代」為故事舞台，描述海賊蒙其·D·魯夫想要得到「ONE PIECE」（一個大秘寶）（ワンピース（ひとつなぎの大秘宝））" +
                    "和成為「海賊王」為夢想而出海向「偉大的航道」航行的海洋冒險故事。";

                return;
            }

            if (comboBox1.Text == "怪獸8號")
            {
                textBox1.Text = "日本是怪獸出現率在世界上名列前茅的「怪獸強國」。日比野卡夫卡，32歲，任職怪獸清潔公司，做著怪物屍體清潔工的工作。他在小時候跟兒時好友亞白米娜約定「一起消滅所有怪獸」。";

                return;
            }



        }

        private void comboBox2_TextChanged(object sender, EventArgs e)
        {
            if (comboBox2.Text == "葬送的芙莉蓮")
            {
                textBox2.Text = "故事背景設定於存在著魔法與奇幻生物的虛構世界，" +
                    "講述勇者一行人打倒魔王之後，" +
                    "勇者一行人中精靈魔法使芙莉蓮的故事。";

                return;
            }

            if (comboBox2.Text == "鬼滅之刃柱訓練篇")
            {
                textBox2.Text = "2024年3月9日，官方宣布《柱訓練篇》將於2024年5月12日正式播出，" +
                    "並且釋出正式預告片";

                return;
            }

            if (comboBox2.Text == "海賊王")
            {
                textBox2.Text = "作品以虛構的「大海賊時代」為故事舞台，描述海賊蒙其·D·魯夫想要得到「ONE PIECE」（一個大秘寶）（ワンピース（ひとつなぎの大秘宝））" +
                    "和成為「海賊王」為夢想而出海向「偉大的航道」航行的海洋冒險故事。";

                return;
            }

            if (comboBox2.Text == "怪獸8號")
            {
                textBox2.Text = "日本是怪獸出現率在世界上名列前茅的「怪獸強國」。" +
                    "日比野卡夫卡，32歲，任職怪獸清潔公司，做著怪物屍體清潔工的工作。" +
                    "他在小時候跟兒時好友亞白米娜約定「一起消滅所有怪獸」。";

                return;
            }
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

        private void comboBox4_TextChanged(object sender, EventArgs e)
        {
            if (comboBox4.Text == "按鈕1")
            {
                button5.Visible = true;

                return;
            }

            if (comboBox4.Text == "按鈕2")
            {
                button6.Visible = true;

                return;
            }

            if (comboBox4.Text == "按鈕3")
            {
                button7.Visible = true;
                return;
            }

            if (comboBox4.Text == "按鈕4")
            {
                button8.Visible = true;
                return;
            }
        }
    }

}