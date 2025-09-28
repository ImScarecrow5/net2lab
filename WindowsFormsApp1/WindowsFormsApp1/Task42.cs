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
    public partial class Task42 : Form
    {
        public Task42()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                double R = Convert.ToDouble(textR.Text);
                double y = Math.PI * R * R;
                ResultBox.Text = Convert.ToString(y);
            }
            catch
            {
                ResultBox.Text = "Неверный ввод данных!";
            }
        }
    }
}
