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
    public partial class Task3 : Form
    {
        public Task3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                int a = Convert.ToInt32(textBox1.Text);
                int b = Convert.ToInt32(textBox2.Text);
                int c = Convert.ToInt32(textBox3.Text);

                int pro = a * b * c;
                int sym = a + b + c;

                if (pro == sym) ResultBox.Text = "Равны";
                else if ((a * b * c) > (a + b + c)) ResultBox.Text = "Произведение";
                else ResultBox.Text = "Сумма";
            }
            catch
            {
                ResultBox.Text = "Неверный ввод данных!";
            }
        }
    }
}
