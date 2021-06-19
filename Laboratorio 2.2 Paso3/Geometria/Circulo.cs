using System;

namespace Geometria
{
    public class Circulo
    {
        private int m_radio;
        private double resultado;

        public int Radio
        {
            get { return m_radio; }
            set { m_radio = value; }
        }

        public Circulo(int r) { Radio = r; }

        public double CalcularPerimetro()
        {
            resultado = 2 * (Math.PI * m_radio);
            return Math.Round(resultado);
        }

        public double CalcularSuperficie()
        {
            resultado = System.Math.PI * (Math.Pow(m_radio, 2));
            return Math.Round(resultado);
        }
    }
}
