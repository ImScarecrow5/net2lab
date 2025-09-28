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
    public partial class Task44 : Form
    {
        public Task44()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                double a = Convert.ToDouble(textA.Text);
                double b = Convert.ToDouble(textB.Text);
                double x = Convert.ToDouble(textX.Text);
                double y = Math.Pow(a * Math.Cos(b * x), 2);
                ResultBox.Text = Convert.ToString(y);
            }
            catch
            {
                ResultBox.Text = "Неверный ввод данных!";
            }
        }
    }
}
