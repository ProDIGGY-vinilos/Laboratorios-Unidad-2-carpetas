using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2._2_Paso4
{
    class Persona
    {
        private string nombre, apellido;
        private int dni, edad;


        public Persona(string nombre, string apellido, int dni, int edad)
        {
            this.nombre = nombre;
            this.apellido = apellido;
            this.dni = dni;
            this.edad = edad;
            Console.WriteLine("Objeto persona creado con exito dni: {0}", this.dni);
        }
        public Persona()
        {
        }
        public string GetNombre()
        {
            return (nombre +" "+ apellido);
        }
    }
}
