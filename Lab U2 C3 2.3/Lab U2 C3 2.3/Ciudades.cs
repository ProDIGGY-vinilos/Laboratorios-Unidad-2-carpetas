using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_U2_C3_2._3
{
    class Ciudades
    {
        private int _codigoPost;
        private string _nombre;

        public Ciudades(int cod, string nom)
        {
            _codigoPost = cod;
            _nombre = nom;
        }
        public int Codigo
            {
                get => _codigoPost;
            }
        public string Nombre
        {
            get => _nombre;
        }
    }
}
