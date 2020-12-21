using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Lib_5;

namespace _8
{
    public partial class Form1 : Form
    {
        // описали глобальные объекты
        Lib_5.GeometricProgression geometricProgression1,
            geometricProgression2;
        public Form1()
        {
            InitializeComponent();
        }

        private void оПрограммеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Создать интерфейс – серия чисел (см. лекцию). Создать класс – геометрическая прогрессия. " +
                "Класс должен включать конструктор. Сравнение производить по шагу прогрессии.");
        }

        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            // проверка конвертации
            try
            {
                int start = Convert.ToInt32(textBox1.Text);
                int step = Convert.ToInt32(textBox2.Text);
                // задаем новые значения
                geometricProgression1.Start = start;
                geometricProgression1.Step = step;
                // начинаем отсчет заново
                geometricProgression1.Reset();
            }
            // выводим подсказку
            catch
            {
                MessageBox.Show("Ошибка конвертации! Должно быть введено целое число.");
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // создаем объекты 
            geometricProgression1 = new GeometricProgression(2, 2);
            geometricProgression2 = new GeometricProgression(2, 3);
        }

        private void следующееЗначениеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // получаем следующее значение
            textBox3.Text = geometricProgression1.GetNext().ToString();
        }

        private void сбросToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // запускаем прогрессию заново и очищаем текст бокс
            geometricProgression1.Reset();
            textBox3.Clear();
        }

        private void сравнить1И2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // сравниваем
            int rez = geometricProgression1.CompareTo(geometricProgression2);
            if (rez == 1) MessageBox.Show("1 прогрессия больше");
            if (rez == -1) MessageBox.Show("2 прогрессия больше");
            if (rez == 0) MessageBox.Show("Прогрессии равны");
        }

        private void изменитьСтартИШагToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // проверка конвертации
            try
            {
                int start = Convert.ToInt32(textBox6.Text);
                int step = Convert.ToInt32(textBox5.Text);
                // задаем новые значения
                geometricProgression2.Start = start;
                geometricProgression2.Step = step;
                // начинаем отсчет заново
                geometricProgression2.Reset();
            }
            // выводим подсказку
            catch
            {
                MessageBox.Show("Ошибка конвертации! Должно быть введено целое число.");
            }
        }

        private void следующееЗначениеToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            // получаем следующее значение
            textBox4.Text = geometricProgression1.GetNext().ToString();
        }

        private void сбросToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            // запускаем прогрессию заново и очищаем текст бокс
            geometricProgression2.Reset();
            textBox4.Clear();
        }
    }
}
