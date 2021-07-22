using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_U2_C3_2._3
{
    class Empleado
    {
        private int Id;
        private string Nombre;
        private decimal Sueldo;

        public Empleado(int id, string nom, decimal sueldo)
        {
            Id = id;
            Nombre = nom;
            Sueldo = sueldo;
        }

        public string Nombr { get => Nombre; }
        public int Idd { get => Id; }
        public decimal Sueld { get => Sueldo; }
    }
}
