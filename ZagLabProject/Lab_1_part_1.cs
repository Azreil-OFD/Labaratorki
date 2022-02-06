#region using

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

#endregion
#region создание класса и неймспейса
namespace ZagLabProject
{
    public partial class Lab_1_part_1 : UserControl
    {
    #endregion


        #region Инициализация

        public Color origFormColor;

        public Lab_1_part_1()
        {
            InitializeComponent();

            origFormColor = tabPage1.BackColor;

            textBox4_2.Text = "5" + (textBox4_1.Text = textBox1.Text = "123");
            
        }
        #endregion

        #region Задание 1

        #region Кнопки
        private void button1_Click(object sender, EventArgs e)
        {
            Clear();
            tabPage1.BackColor = Color.Red;
            button1_1.Enabled = true;
            button1_1.Text = "A";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Clear();
            tabPage1.BackColor = Color.Blue;
            button2_2.Enabled = true;
            button2_2.Text = "A";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Clear();
            tabPage1.BackColor = Color.Green;
            button3_3.Enabled = true;
            button3_3.Text = "A";
        }
        private void button5_Click(object sender, EventArgs e)
        {

            colorDialog1.ShowDialog();
            Clear();
            tabPage1.BackColor = colorDialog1.Color;
            button5_5.Enabled = true;
            button5_5.Text = "A";
        }
        #endregion

        #region Очистка
        private void button4_Click(object sender, EventArgs e)
        {
            tabPage1.BackColor = origFormColor;
            Clear();
        }

        private void Clear()
        {

            button1_1.Text = ".";
            button1_1.Enabled = false;
            button2_2.Text = ".";
            button2_2.Enabled = false;
            button3_3.Text = ".";
            button3_3.Enabled = false;
            button5_5.Text = ".";
            button5_5.Enabled = false;
        }
        #endregion

        #endregion

        #region Задание 2
        private void btn_z2_Click(object sender, EventArgs e)
        {
            switch (((Button)sender).Text)
            {
                case "Привет":
                    zadanie2.Text = "Привет";
                    break;
                case "Пока":
                    zadanie2.Text = "Пока";
                    break;
                case "Ты кто такой?":
                    zadanie2.Text = "Давай досвидания!";
                    break;
            }
        }

        #endregion

        #region Задание 3

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            zadanie3.Text = ((TextBox)sender).Text;
        }

        #endregion

        #region Задание 4
        private void btn4_2_Click(object sender, EventArgs e)
        {
            switch (((Button)sender).Name)
            {
                case "btn4_1":
                    ((Button)sender).Text = textBox4_1.Text;
                    break;
                case "btn4_2":
                    ((Button)sender).Text = textBox4_2.Text;
                    break;
            }
        }

        #endregion

        #region Задание 5
        private void button6_Click(object sender, EventArgs e)
        {
            if (((MouseEventArgs)e).X < 40)
            {
                label1.BackColor = Color.Red;
                label1.ForeColor = Color.White;
                label1.Text = $"красный";
            }
            else if (((MouseEventArgs)e).X < 74)
            {
                label1.BackColor = Color.Green;
                label1.ForeColor = Color.White;
                label1.Text = $"зелённый";
            }
            else {
                label1.BackColor = Color.Blue;
                label1.ForeColor = Color.White;
                label1.Text = $"синий";
            }
            //40 , 74
        }


        #endregion

        #region Задание 6
        private void vScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {
            switch (vScrollBar1.Value)
            {
                case 2:
                    label2.Hide();
                    break;
                case 3:
                    label2.Show();
                    break;

                case 6:
                    label3.Hide();
                    break;
                case 7:
                    label3.Show();
                    break;

                case 10:
                    label4.Hide();
                    break;
                case 11:
                    label4.Show();
                    break;
            }
        }
        #endregion

        #region Задание 7
        private void button9_Click(object sender, EventArgs e)
        {
            if (act == 0)
            {
                ZagLabProject.data.zadanie7 zadanieForm7 = new data.zadanie7();
                zadanieForm7.Show();

            }
            else if (act == 1)
            {
                ZagLabProject.data.zadanie7 zadanieForm7 = new data.zadanie7(textBox4.Text);
                zadanieForm7.Show();
            }

            
        }
        int act = 0;
        private void textBox4_Click(object sender, EventArgs e)
        {
            if (act == 0) {
                ((TextBox)sender).Text = "";
                ((TextBox)sender).ForeColor = Color.Black;
                act = 1;
            }
            
        }

        #endregion

        #region Задание 8

        private void button10_Click(object sender, EventArgs e)
        {
            ZagLabProject.data.zadanieForm8 zadanieForm8 = new data.zadanieForm8() { Text = "" };

            zadanieForm8.Show();

        }

        #endregion

        #region Задание 9
        private void Zadan9(object sender, EventArgs e)
        {
            switch (((Button)sender).Text)
            {
                case "Скрыть":
                    textBox5.Visible = false;
                    break;
                case "Показать":
                    textBox5.Visible = true;
                    break;
                case "Очистить":
                    textBox5.Text = "";
                    break;
                case "Удалить":
                    textBox5.Dispose();
                    break;
            }
        }
        #endregion

        #region Задание 10
        private void button15_Click(object sender, EventArgs e)
        {
            ZagLabProject.data.zadanieForm10 ZForm10 = new ZagLabProject.data.zadanieForm10();

            ZForm10.Show();
        }

        private void button16_Click(object sender, EventArgs e)
        {
            ZagLabProject.data.igra ZForm11 = new ZagLabProject.data.igra();
            ZForm11.Show();
        }

        private void button20_MouseClick(object sender, MouseEventArgs e)
        {
            switch (((Button)sender).Text)
            {
                case "1":
                    bt3.Enabled = false;
                    bt1.Enabled = false;
                    break;
                case "2":
                    bt3.Enabled = true;
                    bt4.Enabled = true;
                    break;
                case "3":
                    bt5.Enabled = false;
                    break;
                case "4":
                    bt2.Enabled = false;
                    break;
                case "5":
                    bt4.Enabled = false;
                    break;
                case "Заново":
                    bt1.Enabled = true;
                    bt2.Enabled = true;
                    bt3.Enabled = true;
                    bt4.Enabled = true;
                    bt5.Enabled = true;
                    break;
                default:
                    break;
            }
        }

        #endregion

        #region Конец
    }




}

#endregion