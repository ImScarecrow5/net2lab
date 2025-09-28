using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Struct : Form
    {
        public Struct()
        {
            Helicopter helicopter = new Helicopter();
            InitializeComponent();
        }


        Helicopter helicopter = new Helicopter();
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                //Model
                //SerialNumber
                //MaxTakeoffWeight
                //MaxSpeed
                //Range

                Object selItem = comboBox1.SelectedItem;
                //Console.WriteLine(selItem.ToString());
                label1.Text = "";
                switch (selItem.ToString())
                {
                    case "Model":
                        helicopter.Model = textBox1.Text;
                        ResultBox.Text = "Данные в Model записаны успешно";
                        break;
                    case "SerialNumber":
                        helicopter.SerialNumber = textBox1.Text;
                        ResultBox.Text = "Данные в SerialNumber записаны успешно";
                        break;
                    case "MaxTakeoffWeight":
                        helicopter.MaxTakeoffWeight = Convert.ToDouble(textBox1.Text);
                        ResultBox.Text = "Данные в MaxTakeoffWeight записаны успешно";
                        break;
                    case "MaxSpeed":
                        helicopter.MaxSpeed = Convert.ToDouble(textBox1.Text);
                        ResultBox.Text = "Данные в MaxSpeed записаны успешно";
                        break;
                    case "Range":
                        helicopter.Range = Convert.ToDouble(textBox1.Text);
                        ResultBox.Text = "Данные в Range записаны успешно";
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

        struct Helicopter
        {
            public string Model;
            public string SerialNumber;
            public double MaxTakeoffWeight;
            public double MaxSpeed;
            public double Range;

            public Helicopter(string a, string b, double c, double d, double e)
            {
                Model = a;
                SerialNumber = b;
                MaxTakeoffWeight = c;
                MaxSpeed = d;
                Range = e;
            }

            public static Helicopter Default => new Helicopter("default", "default", 0, 0, 0);
            public string show()
            {
                return $"Model: {Model},\nSerial number: {SerialNumber},\n" +
                    $"Max take off weight: {MaxTakeoffWeight},\nMax speed: {MaxSpeed},\n" +
                    $"Range: {Range}";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ResultBox.Text = "";
            label1.Text = helicopter.show();
        }
    }
}
