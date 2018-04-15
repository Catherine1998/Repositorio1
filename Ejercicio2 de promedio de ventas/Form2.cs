using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio2_de_promedio_de_ventas
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 f = new Form1();
            f.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                int.Parse(textBox1.Text);
                double.Parse(textBox3.Text);
                double.Parse(textBox4.Text);
                double.Parse(textBox5.Text);
                double.Parse(textBox6.Text);
                double.Parse(textBox7.Text);
                double.Parse(textBox8.Text);
                double.Parse(textBox9.Text);
            }
            catch
            {
                MessageBox.Show("Usted ingreso un dato mal, revise los datos");
                return;
            }
            Ventas ventas1 = new Ventas(int.Parse(textBox1.Text), textBox2.Text, double.Parse(textBox3.Text), double.Parse(textBox4.Text), double.Parse(textBox5.Text), double.Parse(textBox6.Text), double.Parse(textBox7.Text), double.Parse(textBox8.Text), double.Parse(textBox9.Text));
            ventas1.Calcular();

            MessageBox.Show("El promedio de los 6 meses es " + ventas1.Calcular());
        }
    }
}
