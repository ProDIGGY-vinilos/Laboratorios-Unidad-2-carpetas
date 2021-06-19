using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Geometria
{
    public class Cuadrado : Rectangulo
    {
        private int lado;
        public Cuadrado(int lados, int longitud) : base(lados, longitud)
        {
            this.lado = lados;
        }

        public new double CalcularPerimetro()
        {
            resultado = 4 * lado;
            return resultado;
        }

        public override double CalcularSuperficie()
        {
            resultado = Math.Pow(lado, 2);
            return resultado;
        }
    }
}