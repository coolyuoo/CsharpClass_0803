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


            //-----

            comboBox3.Items.Add("國中");
            comboBox3.Items.Add("高中");
            comboBox3.Items.Add("大學");
            comboBox3.Items.Add("研所");


            comboBox3.DropDownStyle = ComboBoxStyle.DropDownList;


            comboBox3.SelectedItem = "國中";



        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked == true)
            {
                textBox1.Text = "臺北市，通稱臺北，是中華民國的首都[4]及直轄市，位於台灣北部的臺北盆地，是臺北都會區以及北台灣的中心城市，亦為臺灣在金融、經濟、政治、科技、教育、文化等領域的發展中心，2020年臺北獲評選爲最高等級的Alpha級國際大都市[5]";

                return;
            }

            if (radioButton2.Checked)
            {
                textBox1.Text = "臺中市，通稱臺中，為中華民國直轄市，臺灣六都之一，也是中臺灣唯一的直轄市。周邊與臺灣省的六個縣相鄰，北鄰苗栗縣、新竹縣，南鄰彰化縣、南投縣，東隔中央山脈與花蓮縣相鄰，東北以中央山脈和雪山山脈毗鄰宜蘭縣，西臨臺灣海峽";

                return;
            }

            if (radioButton3.Checked)
            {
                textBox1.Text = "高雄市，通稱高雄，是中華民國直轄市與臺灣六都之一，地處臺灣西南部。舊稱「打狗」，日治時期因打狗的臺語讀音「Tá-káu」與日語漢字「高雄」的讀音相同而更名；市內擁有臺灣第一大港高雄港，又有「港都」之別稱。全市設籍人口約273萬，轄域面積達2,952平方公里，為南臺灣第一大城、臺灣的第三大城。";

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




        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {

            if (radioButton5.Checked)
            {
                textBox2.Text = "臺中市，通稱臺中，為中華民國直轄市，臺灣六都之一，也是中臺灣唯一的直轄市。周邊與臺灣省的六個縣相鄰，北鄰苗栗縣、新竹縣，南鄰彰化縣、南投縣，東隔中央山脈與花蓮縣相鄰，東北以中央山脈和雪山山脈毗鄰宜蘭縣，西臨臺灣海峽";

                return;
            }

        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {

            if (radioButton4.Checked)
            {
                textBox2.Text = "高雄市，通稱高雄，是中華民國直轄市與臺灣六都之一，地處臺灣西南部。舊稱「打狗」，日治時期因打狗的臺語讀音「Tá-káu」與日語漢字「高雄」的讀音相同而更名；市內擁有臺灣第一大港高雄港，又有「港都」之別稱。全市設籍人口約273萬，轄域面積達2,952平方公里，為南臺灣第一大城、臺灣的第三大城。";

                return;
            }
        }

        private void radioButton6_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton6.Checked == true)
            {
                textBox2.Text = "臺北市，通稱臺北，是中華民國的首都[4]及直轄市，位於台灣北部的臺北盆地，是臺北都會區以及北台灣的中心城市，亦為臺灣在金融、經濟、政治、科技、教育、文化等領域的發展中心，2020年臺北獲評選爲最高等級的Alpha級國際大都市[5]";

                return;
            }


        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }
    }

}