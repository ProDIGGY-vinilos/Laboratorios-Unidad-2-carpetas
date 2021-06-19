using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Geometria
{
    public class Rectangulo : Poligono
    {
        private int bace, altura;
        public Rectangulo(int lados, int longitud) : base(lados, longitud)
        {
            this.bace = lados;
            this.altura = longitud;
        }

        public override double CalcularSuperficie()
        {
            resultado = bace * altura;
            return resultado;
        }

        public new double CalcularPerimetro()
        {
            resultado = 2 * (bace + altura);
            return resultado;
        }
    }
}