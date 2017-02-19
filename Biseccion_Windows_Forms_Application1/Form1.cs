using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Biseccion_Windows_Forms_Application1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double a;
            double b;
            double tol;
            int iteraciones;
            string funcion;
            try
            {
                a = Convert.ToDouble(this.textBox2.Text.ToString());
                b = Convert.ToDouble(this.textBox3.Text.ToString());
                tol = Convert.ToDouble(this.textBox4.Text.ToString());
                funcion = this.textBox1.Text.ToString();
                iteraciones = Convert.ToInt32(this.textBox5.Text);
            }
            catch (FormatException)
            {
                System.Windows.Forms.MessageBox.Show(this,"Format Error", "Advertencia",MessageBoxButtons.OK);
                a = 0;
                b = 1;
                tol = 10e-2;
                iteraciones = 20;
                funcion = "3*(x+1)*(x-(1/2))*(x-1)";
            }
            Biseccion biseccion = new Biseccion();
            biseccion.set_funcion(funcion);
            biseccion.set_intervalo(a,b);
            biseccion.set_tolerancia(tol);
            biseccion.max_iteraciones(iteraciones);
            double resultado = biseccion.solucion(this.dataGridView1);
            if (resultado == -1)
            {
                System.Windows.Forms.MessageBox.Show(this,"No se puede aplicar Biseccion");
            }
            this.textBox6.Text = resultado.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.dataGridView1.Rows.Clear();
        }
    }
}
