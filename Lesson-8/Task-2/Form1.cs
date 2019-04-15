using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

//Иматдинов.
//
//Задача 2
//Создайте простую форму на котором свяжите свойство Text элемента TextBox со свойством
//Value элемента NumericUpDown

namespace Task_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void nUpDown_ValueChanged(object sender, EventArgs e)
        {
            tB.Text = Convert.ToString(nUpDown.Value);
        }
    }
}
