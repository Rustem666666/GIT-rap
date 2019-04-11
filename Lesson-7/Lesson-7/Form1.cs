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
//Задача 1.
//а) Добавить в программу «Удвоитель» подсчёт количества отданных команд удвоителю.
//б) Добавить меню и команду «Играть». При нажатии появляется сообщение, какое число
//должен получить игрок.Игрок должен получить это число за минимальное количество ходов.
//в) * Добавить кнопку «Отменить», которая отменяет последние ходы.Используйте
// обобщенный класс Stack.
// Вся логика игры должна быть реализована в классе с удвоителем.


namespace Lesson_7
{
    public partial class Form1 : Form
    {
        Stack<int> numbers = new Stack<int>();
        int a = 0;
        int b = 0;
        string countText;
        bool game = false;
        Random r = new Random();
        public Form1()
        {
            countText = "Выполнено операций - ";
            InitializeComponent();
            btnCommand1.Text = "+1";
            btnCommand2.Text = "x2";
            btnReset.Text = "Сброс";
            btnCancel.Text = "Отмена";
            lblNumber.Text = "0";
            lblOperationsCount.Text = countText + "0";
            lblTextGame.Text = "";
            lblGameN.Text = "";
            this.Text = "Удвоитель";
            toolStripMenuItem1.Text = "Меню";
            toolStripMenuItem2.Text = "Играть";
        }

        /// <summary>
        /// Сбрасывает значения игры по умолчанию
        /// </summary>
        private void ResetGame()
        {
            a = -1;
            countText = "Выполнено операций - ";
            lblTextGame.Text = "";
            lblGameN.Text = "";
            lblNumber.Text = "0";
            game = false;
            btnCancel.Enabled = false;
            btnReset.Enabled = true;
        }
        
        /// <summary>
        /// Конец игры подводит итог и сбрасывает значения.
        /// </summary>
        private void GameOver()
        {
            if (int.Parse(lblNumber.Text) == b)
            {
                MessageBox.Show($"Поздравляем!\nВы подобрали число {b} за {a} попыток.", "Игра окончена!");
                ResetGame();
                OpCount();
            }
            else
            {
                MessageBox.Show($"Вы проиграли!\nУ вас получилось слишком большое число.", "Игра окончена!");
                ResetGame();
                OpCount();
            }
        }

        /// <summary>
        /// Подсчитывает количество операций и возвращает в lblOperationsCount
        /// </summary>
        private void OpCount()
        {
            a = a + 1;
            lblOperationsCount.Text = countText + a;
            if (int.Parse(lblNumber.Text) >= b && game == true) GameOver();
            if (game == true) numbers.Push(int.Parse(lblNumber.Text));
        }

        private void button1_Click(object sender, EventArgs e)
        {
            lblNumber.Text = (int.Parse(lblNumber.Text) + 1).ToString();
            OpCount();
        }

        private void btnCommand2_Click(object sender, EventArgs e)
        {
            lblNumber.Text = (int.Parse(lblNumber.Text) * 2).ToString();
            OpCount();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            lblNumber.Text = "1";
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            btnReset.Enabled = false;
            countText = "Количество попыток - ";
            b = r.Next(1, 100);
            a = -1;
            game = true;
            btnCancel.Enabled = true;
            lblNumber.Text = "0";
            MessageBox.Show($"Вы должны получить число - {b} за минимальное количество попыток.", "Правилы игры");
            OpCount();
            lblTextGame.Text = "Требуемое число:";
            lblGameN.Text = Convert.ToString(b);
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            try
            {
                a = a - 1;
                int buf = int.Parse(lblNumber.Text);
                lblOperationsCount.Text = countText + a;
                lblNumber.Text = Convert.ToString(numbers.Pop());
                if (int.Parse(lblNumber.Text) == buf) lblNumber.Text = Convert.ToString(numbers.Pop());
            }
            catch (InvalidOperationException)
            {
                a = a + 1;
                lblOperationsCount.Text = countText + a;
                MessageBox.Show($"Отменить ход нельзя", "Ошибка");
            }

        }
    }
}
