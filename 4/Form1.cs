using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (int.TryParse(textBox1.Text, out int value))
            {
                double radius = value;
                double area = Math.PI * radius * radius;
                textBox3.Text = area.ToString("F2");
            }
            else
            {
                textBox3.Text = "";
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            if (int.TryParse(textBox2.Text, out int value))
            {
                double radius = value;
                double volume = (4.0 / 3.0) * Math.PI * radius * radius * radius;
                textBox4.Text = volume.ToString("F2");
            }
            else
            {
                textBox4.Text = "";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "" && textBox2.Text != "")
            {
                double circleArea = Math.PI * double.Parse(textBox1.Text) * double.Parse(textBox1.Text);
                double sphereVolume = (4.0 / 3.0) * Math.PI * double.Parse(textBox2.Text) * double.Parse(textBox2.Text) * double.Parse(textBox2.Text);
                textBox3.Text = circleArea.ToString("F2");
                textBox4.Text = sphereVolume.ToString("F2");
            }
            else
            {
                MessageBox.Show("Будь ласка, введіть значення в обидва поля.");
            }
        }

    }
}