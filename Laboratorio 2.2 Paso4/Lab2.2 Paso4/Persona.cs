using System;

namespace Lab2._2_Paso4
{
    class Persona : Program
    {
        private string nombre, apellido;
        private int dni, edad;
        DateTime fecha = DateTime.Now;

        public string Nombre { get => nombre; set => nombre = value; }
        public string Apellido { get => apellido; set => apellido = value; }
        public int Dni { get => dni; set => dni = value; }
        public int Edad { get => edad; set => edad = value; }

        public Persona(string nombre, string apellido, int dni, int edad)
        {
            this.Nombre = nombre;
            this.Apellido = apellido;
            this.Dni = dni;
            this.Edad = edad;
            
        }
        public Persona()
        {
        }

        public int GetAge()
        {
            int anos = 0;
            anos = fecha.Year - this.edad;
            return anos;
        }
        public string GetFullName()
        {
            return (Nombre +" "+ Apellido);
        }
    }
}
