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
    public partial class Task1 : Form
    {
        public Task1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                double x;
                double y;
                double z;

                x = Convert.ToDouble(textBox1.Text);
                y = Convert.ToDouble(textBox2.Text);
                z = Convert.ToDouble(textBox3.Text);

                Console.WriteLine(x);
                Console.WriteLine(y);
                Console.WriteLine(z);
                Console.WriteLine();

                double a = 0.0;
                double b = 0.0;

                a = ((1 + Math.Pow(Math.Sin(x + y), 2)) / (2 + Math.Abs(x - (2 * x) / (1 + x * x * y * y))) + x);
                b = Math.Pow(Math.Cos(Math.Atan(1 / z)), 2);

                ResultBox.Text = $"Результат:\nДля а: {a}\nДля b: {b}";
            }
            catch
            {
                ResultBox.Text = "Неверный ввод данных!";
            }
        }
    }
}
