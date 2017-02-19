using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biseccion_Windows_Forms_Application1
{
    class Newton
    {
        private int iteraciones;

        public Newton(int iteraciones)
        {
            this.iteraciones = iteraciones;
        }

        public void Solucion(System.Windows.Forms.DataGridView data)
        {
            
        }
        private double fun(double x)
        {
            //x^2-6
            return Math.Pow(x,2)-6;

        }
        private double fun_dev(double x)
        {
            //2x derivada de x^2-6
            return 2*x;

        }
    }
}
