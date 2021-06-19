using System;
using System.Collections;

namespace Lab2._2_Paso4
{
    class Program
    {
        public static void Main()
        {                 
            Persona persona = new();

            ArrayList personas = new ArrayList();
            //personas.Add(persona);
            Console.Write("Bienvenido "); Console.WriteLine("Que desea hacer?");
            Console.WriteLine("1: Agregar una nueva persona");
            Console.WriteLine("2: Buscar una persona");
            Console.WriteLine("3: Modificar una persona");
            Console.WriteLine("4: Eliminar una persona");
            int opc = int.Parse(Console.ReadLine());
            switch (opc)
            {
                case 1:
                    personas.Add(AgregarPersona());
                    Main();
                    break;
                case 2:
                    MostrarPersona(personas);                   
                    break;
                case 3:
                    break;
                case 4:
                    break;
                default:
                    break;
            }            
            Console.ReadKey();
        }
        static object AgregarPersona()
        {
            int _dni, _edad;
            string _nombre, _apellido;

            Console.WriteLine("A continuacion indique los datos de la nueva persona...");
            Console.Write(" Indique nombre: "); _nombre = Console.ReadLine();
            Console.Write(" Indique apellido: "); _apellido = Console.ReadLine();
            Console.Write(" Indique edad: "); _edad = int.Parse(Console.ReadLine());
            Console.Write(" Indique dni: "); _dni = int.Parse(Console.ReadLine());
            Persona persona = new(_nombre, _apellido, _dni, _edad);
            return persona;
        }
        static void MostrarPersona(ArrayList personas)
        {
            //Persona persona1 = (Persona)personas[0];
            foreach (Persona person in personas)
            {
                Console.WriteLine(person.GetNombre());
                Console.WriteLine();
            }
            Console.WriteLine("foreach terminado");
        }
    }
}
