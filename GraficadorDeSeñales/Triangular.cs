using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraficadorDeSeñales
{
    class Triangular
    {
        public List<Muestra> Muestras { get; set; }

        public Triangular()
        {
            Muestras = new List<Muestra>();
        }

        public double evaluar(double tiempo)
        {
            double resultado;
            if (Math.Abs(tiempo) < 1)
            {
                resultado = 1 - Math.Abs(tiempo);
            }
            else if (Math.Abs(tiempo) >= 1)
            {
                resultado = 0.0;
            }
            else
            {
                resultado = 0.0;
            }
            return resultado;
        }
    }
}
