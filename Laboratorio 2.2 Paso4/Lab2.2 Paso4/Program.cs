using System;
using System.Collections;
using System.Collections.Generic;

namespace Lab2._2_Paso4
{
    class Program
    {
        public static void Main()
        {
            List<Persona> personas = new List<Persona>();         
            Menu(personas);
            Console.ReadKey();
        }

        private static void Menu(List<Persona> personas)
        {
            /*Texto Menu*/ Console.WriteLine("Bienvenido "); Console.WriteLine("Que desea hacer?"); Console.WriteLine("1: Agregar una nueva persona"); Console.WriteLine("2: Mostrar lista de personas"); Console.WriteLine("3: Modificar una persona"); Console.WriteLine("4: Eliminar una persona"); Console.WriteLine("5: Limpiar Consola"); Console.WriteLine("6: SALIR");
            int opc = int.Parse(Console.ReadLine());
            switch (opc)
            {
                case 1: // Agregar nuevo objeto
                    Console.WriteLine("A continuacion indique los datos de la persona...");
                    personas.Add(AgregarPersona());
                    Console.WriteLine("-----------------------"); int cont = personas.Count - 1; 
                    Console.WriteLine("Persona {0}  de {1} años añadida con exito", personas[cont].GetFullName(), personas[cont].GetAge());
                    Console.WriteLine("-----------------------");
                    Menu(personas);
                    break;
                case 2: // Mostrar Lista
                    MostrarPersonas(personas);
                    Menu(personas);                      
                    break;
                case 3: // Modificar objeto

                    int num, op;
                    Console.WriteLine("Ingrese el numero de la posicion que ocupa la persona a modificar"); num = int.Parse(Console.ReadLine());
                    if (num < 0 || num > personas.Count -1)
                    { Console.WriteLine("Opcion incorrecta..."); Console.WriteLine("Volviendo al menu..."); Menu(personas); }
                    else
                    {
                        Console.WriteLine("Esta seguro que desea modificar a la siguiente persona?: {0} ", personas[num].GetFullName()); Console.WriteLine("1 = si / 2 = no"); op = int.Parse(Console.ReadLine());
                        if (op == 1)
                        {
                            Console.WriteLine("\f Estos son los datos de la persona seleccionada: ");
                            Console.WriteLine("Nombre: {0} Apellido: {1} DNI: {2} Edad: {3} Año Nacimiento: {4}", personas[num].Nombre, personas[num].Apellido, personas[num].Dni, personas[num].GetAge(), personas[num].Edad ); Console.WriteLine("---------------------------------------------------");
                            Console.WriteLine("A continuacion vaya ingresando los datos nuevos (En caso de querer mantener algun dato solo vuelva a escribirlo)");
                            personas.RemoveAt(num);
                            personas.Insert(num, AgregarPersona());                               
                        }
                        else { Console.WriteLine("Volviendo al menu... presione una tecla"); Console.ReadKey(); Console.Clear(); Menu(personas); }
                    }
                    Console.WriteLine("Volviendo al menu... presione una tecla"); Console.ReadKey(); Console.Clear(); Menu(personas);
                    break;
                case 4: // Eliminar objeto
                    EliminarPersona(personas);
                    break;
                case 5:
                    Console.Clear();
                    Menu(personas);
                    break;
                case 6:
                    Console.WriteLine("Saliendo, muchas gracias por pasarse :)");
                    break;
                default:
                    Console.WriteLine("Opcion incorrecta, eliga uno de las opciones correctas (1-2-3-4-5-6)");
                    Console.WriteLine("Presione una tecla para continuar");
                    Console.ReadKey(); Console.Clear(); Menu(personas);
                    break;
            }
        }

        private static void EliminarPersona(List<Persona> personas)
        {
            int cont, op;
            Console.WriteLine("Ingrese el numero de la persona que desee eliminar (Personas en el listado {0})", (personas.Count - 1));
            cont = int.Parse(Console.ReadLine());
            if (cont > (personas.Count - 1) || cont < 0)
            { Console.WriteLine("Opcion incorrecta..."); Console.WriteLine("Volviendo al menu..."); Menu(personas); }
            else
            {
                Console.WriteLine("Esta seguro que desea borrar a la siguiente persona?: {0} ", personas[cont].GetFullName()); Console.WriteLine("1 = si / 2 = no"); op = int.Parse(Console.ReadLine());
                if (op == 1)
                {
                    Console.WriteLine("Persona {0} eliminada", personas[cont].GetFullName());
                    personas.RemoveAt(cont);
                }
                else { Console.WriteLine("Volviendo al menu... presione una tecla"); Console.ReadKey(); Console.Clear(); Menu(personas); }
            }
            Console.WriteLine("Volviendo al menu... presione una tecla"); Console.ReadKey(); Console.Clear(); Menu(personas);
        }

        public static Persona AgregarPersona()
        {
            int _dni, _edad;
            string _nombre, _apellido;
                        
            Console.Write(" Indique nombre: "); _nombre = Console.ReadLine();
            Console.Write(" Indique apellido: "); _apellido = Console.ReadLine();
            Console.Write(" Indique Año nacimiento: "); _edad = int.Parse(Console.ReadLine());
            Console.Write(" Indique dni: "); _dni = int.Parse(Console.ReadLine());
            Persona persona = new(_nombre, _apellido, _dni, _edad);
            
            return(persona);            
        }

        public static void MostrarPersonas(List<Persona> personas)
        {
            int cont = 0;
            Console.WriteLine("Gente en la lista: ");
            Console.WriteLine("---------------------------------------------------");
            foreach (Persona per in personas)
            {
                Console.WriteLine("Nro: {0} -  {1} {2} años", cont, per.GetFullName(),  per.GetAge());        
                cont++;
            }
            Console.WriteLine("---------------------------------------------------");

            
        }

    }
}
