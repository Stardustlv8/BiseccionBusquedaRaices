using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using info.lundin.math;

namespace Biseccion_Windows_Forms_Application1
{
    class prueba
    {
        public static void Main(string [] args)
        {
            ExpressionParser parser = new ExpressionParser();
            Hashtable h = new Hashtable();
            h.Add('x',1.ToString());
            parser.Values.Add("x",2);
            double resultado = parser.Parse("x^2cos(x)");
            Console.WriteLine("Resultado: {0}",resultado);
            Console.ReadKey();
        }
    }
}
