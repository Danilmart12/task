using System;
using System.Windows.Forms;

namespace Task_2.ПЗ_з_графічним_інтерфейсом_для_розв_язання_КР
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            int a, b, c;
            bool isANumber = int.TryParse(textBox1.Text, out a);
            bool isBNumber = int.TryParse(textBox2.Text, out b);
            bool isCNumber = int.TryParse(textBox3.Text, out c);

            if (!isANumber || !isBNumber || !isCNumber)
            {
                label8.Text = "Введено некоректні значення. Будь ласка, введіть числа.";
                return;
            }

            float discriminant = b * b - 4 * a * c;

            if (a != 0)
            {
                if (discriminant > 0)
                {
                    double x1 = (-b + Math.Sqrt(discriminant)) / (2 * a);
                    double x2 = (-b - Math.Sqrt(discriminant)) / (2 * a);

                    label6.Text = $"x1 = {x1:F2}";
                    label8.Text = $"x2 = {x2:F2}";
                }
                else if (discriminant == 0)
                {
                    double x = -b / (2 * a);
                    label8.Text = $"x = {x:F2}";
                }
                else
                {
                    label8.Text = "Рівняння не має дійсних коренів";
                }
            }
            else if (discriminant == 0)
            {
                double x = -b / (2 * a);

                if (x != 0)
                {
                    label8.Text = $"x = {x:F2}";
                }
                else
                {
                    label8.Text = "Значення x не відповідає умовам";
                }
            }
            else
            {
                label8.Text = "Рівняння не має дійсних коренів";
            }
        }
    }
}
