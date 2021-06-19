using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Geometria
{
    public abstract class Poligono
    {
        private int lados;
        private int[] longitud;
        public double resultado;

        public Poligono(int lados, int longitud)
        {
            this.lados = lados;             
            for (int i = 0; i < lados; i++)
            {
                Console.WriteLine("Ingrese longitud {0} ", (i + 1));
                this.longitud[i] = int.Parse(Console.ReadLine());
                Console.Clear();              
            }
            
        }

        public double CalcularPerimetro()
        {
            for (int i = 0; i < lados; i++)
            {
                resultado = longitud[i] * resultado;
            }
            return resultado;
        }

        public abstract double CalcularSuperficie();
       
    }
}