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
    public partial class Task2 : Form
    {
        public Task2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                int x4 = 0;
                int y4 = 0;

                int x1 = Convert.ToInt32(textX1.Text);
                int y1 = Convert.ToInt32(textY1.Text);
                int x2 = Convert.ToInt32(textX2.Text);
                int y2 = Convert.ToInt32(textY2.Text);
                int x3 = Convert.ToInt32(textX3.Text);
                int y3 = Convert.ToInt32(textY3.Text);

                Console.WriteLine("1");
                Console.WriteLine(x1 + " " + y1 + " " + x2 + " " + y2 + " " + x3 + " " + y3);

                if (y1 == y2)
                {
                    y4 = y3;
                    x4 = Math.Abs(x1 - x2) + x3;
                }
                else if (y1 == y3)
                {
                    y4 = y2;
                    x4 = Math.Abs(x1 - x3) + x2;
                }
                else if (y3 == y2)
                {
                    y4 = y1;
                    x4 = Math.Abs(x3 - x2) + x1;
                }

                ResultBox.Text = $"Результат: ({x4};{y4})";
            }
            catch
            {
                ResultBox.Text = "Неверный ввод данных!";
            }
        }
    }
}
