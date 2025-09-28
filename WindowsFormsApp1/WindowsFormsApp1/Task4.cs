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
    public partial class Task4 : Form
    {
        public Task4()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                double y, x, R, a, b;
                Console.WriteLine("Выберите 1-4");
                int k = Convert.ToInt32(textBox1.Text);
                switch (k)
                {
                    case 1:
                        Task41 task41 = new Task41();
                        task41.Show();
                        break;
                    case 2:
                        Task42 task42 = new Task42();
                        task42.Show();

                        break;
                    case 3:
                        Task43 task43 = new Task43();
                        task43.Show();
                        
                        break;
                    case 4:
                        Task44 task44 = new Task44();
                        task44.Show();
                        break;
                    default:
                        ResultBox.Text = "Неверный ввод данных!";
                        break;
                }
            }
            catch
            {
                ResultBox.Text = "Неверный ввод данных!";
            }
        }
    }
}
