using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

//Иматдинов
//
//Задача 2.
//Используя Windows Forms, разработать игру «Угадай число». Компьютер загадывает число от
//1 до 100, а человек пытается его угадать за минимальное число попыток.Компьютер говорит,
//больше или меньше загаданное число введенного.
//a) Для ввода данных от человека используется элемент TextBox;

namespace Task_2
{
    public partial class Form1 : Form
    {
        Random r = new Random();
        int n = 0;

        public Form1()
        {
            InitializeComponent();
            Text = "Угадай число";
            btnGame.Text = "Играть";
            btnTry.Text = "Угадать";
            lblInputText.Text = "Введите число от 1 до 100";
            lbltextGame.Text = "Компьютер загадал число от 1 до 100.\nВаша задача отгадать число за минимальное\nколичество попыток.";
        }

        private void btnGame_Click(object sender, EventArgs e)
        {
            int a = r.Next(1, 100);
            
            btnGame.Text = Convert.ToString(a);
            btnGame.Enabled = false;
            btnGame.Visible = false;
            lblInputText.Enabled = true;
            lblInputText.Visible = true;
            lbltextGame.Enabled = true;
            lbltextGame.Visible = true;
            tBInput.Enabled = true;
            tBInput.Visible = true;
            btnTry.Enabled = true;
            btnTry.Visible = true;
        }

        private void btnTry_Click(object sender, EventArgs e)
        {
            n++;
            string s;
            if (tBInput.Text == btnGame.Text)
            {
                MessageBox.Show($"Поздравляю, вы угадали число.\nКоличество попыток {n}", "Игра окончена");
                btnGame.Text = "Играть ещё";
                btnGame.Enabled = true;
                btnGame.Visible = true;
                lblInputText.Enabled = false;
                lblInputText.Visible = false;
                lbltextGame.Enabled = false;
                lbltextGame.Visible = false;
                tBInput.Enabled = false;
                tBInput.Visible = false;
                btnTry.Enabled = false;
                btnTry.Visible = false;
                tBInput.Text = "";
                n = 0;
            }
            else
            {
                if (int.Parse(tBInput.Text) < int.Parse(btnGame.Text))
                {
                    if (int.Parse(btnGame.Text) - int.Parse(tBInput.Text) > 30)
                    {
                        s = " слишком ";
                    }
                    else
                    {
                        s = " "; 
                    }
                    MessageBox.Show($"Вы ввели{s}маленькое число...Попробуйте ещё раз", $"Попытка {n}");
                }
                else
                {
                    if (int.Parse(tBInput.Text) - int.Parse(btnGame.Text) > 30)
                    {
                        s = " слишком ";
                    }
                    else
                    {
                        s = " ";
                    }
                    MessageBox.Show($"Вы ввели{s}большое число...Попробуйте ещё раз", $"Попытка {n}");
                }
            }
        }
    }
}
