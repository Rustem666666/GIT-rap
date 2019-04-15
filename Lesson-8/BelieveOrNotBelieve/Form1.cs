using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

//а) Создать приложение, показанное на уроке, добавив в него защиту от возможных ошибок(не
//создана база данных, обращение к несуществующему вопросу, открытие слишком большого
//файла и т.д.).
//б) Изменить интерфейс программы, увеличив шрифт, поменяв цвет элементов и добавив
//другие «косметические» улучшения на свое усмотрение.
//в) Добавить в приложение меню «О программе» с информацией о программе(автор, версия,
//авторские права и др.).
//г)* Добавить пункт меню Save As, в котором можно выбрать имя для сохранения базы данных
//(элемент SaveFileDialog).

namespace BelieveOrNotBelieve
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        TrueFalse database;



        // Обработчик пункта меню Save
        private void miSave_Click(object sender, EventArgs e)
        {
            if (database != null)
            {
                SaveFileDialog sfd = new SaveFileDialog();
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    database[(int)nudNumber.Value - 1].text = tboxQuestion.Text;
                    database[(int)nudNumber.Value - 1].trueFalse = cboxTrue.Checked;
                    database.Save(sfd.FileName);
                }
            }
            else MessageBox.Show("База данных не должна быть пустой");
        }
        // Обработчик пункта меню Open
        private void miOpen_Click_1(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                database = new TrueFalse(ofd.FileName);
                try
                {
                    database.Load();
                    nudNumber.Minimum = 1;
                    nudNumber.Maximum = database.Count;
                    nudNumber.Value = 1;
                }
                catch (InvalidOperationException)
                {
                    MessageBox.Show("Неверный формат файла, либо файл повреждён.\nСоздайте базу данных заного, либо откройте другую.", "Ошибка");
                }

            }
        }

        // Обработчик пункта меню New
        private void miNew_Click_1(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                database = new TrueFalse(sfd.FileName);
                database.Add("123", true);
                database.Save();
                nudNumber.Minimum = 1;
                nudNumber.Maximum = 1;
                nudNumber.Value = 1;
            };
        }

        // Обработчик пункта меню Exit
        private void miExit_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        // Обработчик события изменения значения numericUpDown
        private void nudNumber_ValueChanged_1(object sender, EventArgs e)
        {
            try
            {
                tboxQuestion.Text = database[(int)nudNumber.Value - 1].text;
                cboxTrue.Checked = database[(int)nudNumber.Value - 1].trueFalse;
            }
            catch (Exception)
            {
                MessageBox.Show("Обращение к несуществующему элементу!\nОткройте или создайте базу данных!", "Ошибка");
            }

        }

        // Обработчик кнопки Добавить
        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (database == null)
            {
                MessageBox.Show("Создайте новую базу данных", "Сообщение");
                return;
            }
            database.Add((database.Count + 1).ToString(), true);
            nudNumber.Maximum = database.Count;
            nudNumber.Value = database.Count;
        }

        // Обработчик кнопки Сохранить (вопрос)
        private void btnSaveQuest_Click_1(object sender, EventArgs e)
        {
            try
            {
                database[(int)nudNumber.Value - 1].text = tboxQuestion.Text;
                database[(int)nudNumber.Value - 1].trueFalse = cboxTrue.Checked;
                database.Save();
                MessageBox.Show("Успешно сохранено!", "Хм");
            }
            catch (NullReferenceException)
            {
                MessageBox.Show("Обращение к несуществующему элементу!\nОткройте или создайте базу данных!", "Ошибка");
            }
        }

        // Обработчик кнопки Удалить
        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (database == null) MessageBox.Show("Обращение к несуществующему элементу!", "Ошибка");
            if (nudNumber.Maximum == 1 || database == null) return;
            database.Remove((int)nudNumber.Value - 1);
            nudNumber.Maximum--;
            if (nudNumber.Value > 1) nudNumber.Value = nudNumber.Value;
        }

        private void miInfo_Click(object sender, EventArgs e)
        {
            new Form2().Show();
        }
    }
}
