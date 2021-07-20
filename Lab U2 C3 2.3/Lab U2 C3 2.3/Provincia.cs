using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_U2_C3_2._3
{
    public class Provincia
    {         
            private string _nombre;

            public Provincia(string nombre)
            {
                _nombre = nombre;
            }

            public Provincia()
            {
            }

            public string NombreProvincia
            {
                get => _nombre;
            }
        
    }
}
