using System;

using MathNet.Numerics;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using info.lundin.math;

namespace Biseccion_Windows_Forms_Application1
{
    class Biseccion
    {
        double a;
        double b;
        double tol;
        int iteraciones;
        string funcion_algebraica;

        public Biseccion(double a, double b, double tol, int iteraciones)
        {
            this.a = a;
            this.b = b;
            this.tol = tol;
            this.iteraciones = iteraciones;
        }
        public Biseccion()
        {

        }
        public void set_funcion(string funcion_algebraica)
        {
            this.funcion_algebraica = funcion_algebraica;
        }
        public void set_intervalo(double a, double b)
        {
            this.a = a;
            this.b = b;
        }
        public void set_tolerancia(double tol)
        {
            this.tol = tol;
        }
        public void max_iteraciones(int iteraciones)
        {
            this.iteraciones = iteraciones;
        }

        public double solucion(System.Windows.Forms.DataGridView data)
        {
            double pm;
            double fa ;
            double fb ;
            double fpm;
            int it = 0;
            do
            {
                pm = Math.Round((a + b) / 2,7);
                fa = funcion(a);
                fb = funcion(b);
                fpm = funcion(pm);
                
                if(fpm * fa > 0)
                {
                    return -1;
                }
                data.Rows.Add(it, a, b, pm, fa, fb, fpm);
                if (fpm * fa < 0 )
                {
                    b = pm;
                }            
                else
                {
                    a = pm;
                }
                it++;
            } while (it <= iteraciones && Math.Abs(fpm) >= tol);
            return pm;
        }

        public double funcion(double x)
        {
            ExpressionParser evaluador = new ExpressionParser();
            evaluador.Values.Add("x",x);
            double resultado=evaluador.Parse(this.funcion_algebraica);
            return Math.Round(resultado,7);
        }
    }
}
