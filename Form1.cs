using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pr19_leskiv


{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
        }
        private void вычислитьToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void файлToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void оПрограммеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 newF = new Form2();
            newF.Show();
        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btn_Close1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void очиститьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox_Date1.Clear();
            textBox_Date2.Clear();
            textBox_Date3.Clear();
            textBox_Result.Clear();
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void textBox_Date1_MouseHover(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(textBox_Date1, "Введите число!");
        }
        private void textBox_Date2_MouseHover(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(textBox_Date2, "Введите число!");
        }
        private void textBox_Date3_MouseHover(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(textBox_Date3, "Введите число!");
        }
        private void textBox_Result1_MouseHover(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(textBox_Result, "Сюда будет выведен результат");
        }
        private void btn_Math1_MouseHover(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(btn_Math1, "Выполнить расчёт");
        }
        private void btn_Close_MouseHover(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(btn_Close1, "Выход из приложения");
        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
        private void btn_Mach1_Click(object sender, EventArgs e)
        {
            try
            {
                double v1, v2, v3, v4, v5, v6, v7, v8, v9;
                double x = double.Parse(textBox_Date1.Text);
                double a = double.Parse(textBox_Date1.Text);
                double b = double.Parse(textBox_Date1.Text);
                v1 = b * Math.Pow(x, 2);
                v2 = v1 - a;
                v3 = Math.Pow(Math.E, a * x);
                v4 = v3 - 1;
                v5 = v2 / v4;
                v6 = v1 + a;
                v7 = v3 + 1;
                v8 = v6 / v7;
                v9 = v5 + v8;
                double q = v9;
                textBox_Result.Text = q.ToString();
            }
            catch (FormatException fe) 
            {
                MessageBox.Show("Проверьте правильность введенных данных!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textBox_Date1.Clear();
                textBox_Date2.Clear();
                textBox_Date3.Clear();
                textBox_Result.Clear();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        private void программаРасчётыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            btn_Mach1_Click(sender, e);
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
