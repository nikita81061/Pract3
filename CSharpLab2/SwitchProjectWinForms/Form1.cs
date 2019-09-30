using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SwitchProjectWinForms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            System.Globalization.CultureInfo customCulture = (System.Globalization.CultureInfo)
            System.Threading.Thread.CurrentThread.CurrentCulture.Clone();
            customCulture.NumberFormat.NumberDecimalSeparator = ".";
            System.Threading.Thread.CurrentThread.CurrentCulture = customCulture;
        }

        private void ButtonExit_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void ButtonDay_Click(object sender, EventArgs e)
        {
            int dayOfWeek = Convert.ToInt32(textBoxA.Text);
            if (dayOfWeek <= 7)
            {
                switch (dayOfWeek)
                {
                    case 1:
                        labelRes.Text = ("Понедельник");
                        break;
                    case 2:
                        labelRes.Text = ("Вторник");
                        break;
                    case 3:
                        labelRes.Text = ("Среда");
                        break;
                    case 4:
                        labelRes.Text = ("Четверг");
                        break;
                    case 5:
                        labelRes.Text = ("Пятница");
                        break;
                    case 6:
                        labelRes.Text = ("Суббота");
                        break;
                    case 7:
                        labelRes.Text = ("Воскресенье");
                        break;
                }
            }
            else
            {
                MessageBox.Show("Такого дня не существует!");
            }
        }

        private void ButtonMonth_Click(object sender, EventArgs e)
        {
            int monthOfYear = Convert.ToInt32(textBoxB.Text);
            if (monthOfYear <= 12)
            {
                switch (monthOfYear)
                {
                    case 1:
                        labelRes.Text = ("Январь");
                        break;
                    case 2:
                        labelRes.Text = ("Февраль");
                        break;
                    case 3:
                        labelRes.Text = ("Март");
                        break;
                    case 4:
                        labelRes.Text = ("Апрель");
                        break;
                    case 5:
                        labelRes.Text = ("Май");
                        break;
                    case 6:
                        labelRes.Text = ("Июнь");
                        break;
                    case 7:
                        labelRes.Text = ("Июль");
                        break;
                    case 8:
                        labelRes.Text = ("Август");
                        break;
                    case 9:
                        labelRes.Text = ("Сентябрь");
                        break;
                    case 10:
                        labelRes.Text = ("Октябрь");
                        break;
                    case 11:
                        labelRes.Text = ("Ноябрь");
                        break;
                    case 12:
                        labelRes.Text = ("Декабрь");
                        break;
                }
            }
            else
            {
                MessageBox.Show("Такого месяца не существует!");
            }
        }

        private void ButtonOperation_Click(object sender, EventArgs e)
        {
            double a = Convert.ToDouble(textBoxA.Text);
            double b = Convert.ToDouble(textBoxB.Text);
            
                switch (textBoxOperation.Text)
                {
                    case "+":
                        double addition;
                        addition = a + b;
                        labelRes.Text = Convert.ToString(addition);
                        break;
                    case "-":
                        double subtraction;
                        subtraction = a - b;
                        labelRes.Text = Convert.ToString(subtraction);
                        break;
                    case "*":
                        double multiplication;
                        multiplication = a * b;
                        labelRes.Text = Convert.ToString(multiplication);
                        break;
                    case "/":
                        double segmentation;
                        segmentation = a / b;
                        labelRes.Text = Convert.ToString(segmentation);
                        break;
                }
          
        }

        private void TextBoxNumA_TextChanged(object sender, EventArgs e)
        {

        }

        private void TextBoxNumB_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
