using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabSintaxis2
{
    public class Parte1
    {
        public static void Parte()
        {
            string inputTexto;
            Console.WriteLine("Ingrese un texto a analizar ");
            inputTexto = Console.ReadLine();
            Console.WriteLine(inputTexto);
            if (String.IsNullOrEmpty(inputTexto))
            {
                Console.WriteLine("Falta ingresar texto, cerrando....");
            }
            else
            {
                Console.WriteLine("Texto ingresado es: " + inputTexto);
                Console.WriteLine("Opcion 1: " + inputTexto.ToUpper());
                Console.WriteLine("Opcion 2: " + inputTexto.ToLower());
                Console.WriteLine("Opcion 3: " + inputTexto.Length);
                Console.WriteLine("Opciona  ingresar: ");
                ConsoleKeyInfo opcion = Console.ReadKey();
                Console.WriteLine();

                if (opcion.Key == ConsoleKey.D1 || opcion.Key == ConsoleKey.NumPad1 )
                {
                    Console.WriteLine("Opcion 1 ingresada");
                }
                else if (opcion.Key == ConsoleKey.D2 || opcion.Key == ConsoleKey.NumPad2)
                {
                    Console.WriteLine("Opcion 2 ingresada");
                }
                else if (opcion.Key == ConsoleKey.D3 || opcion.Key == ConsoleKey.NumPad3)
                {
                    Console.WriteLine("Opcion 3 ingresada");
                }
                else
                {
                    Console.WriteLine("Opcion ingresada erronea, saliendo....");
                }

            }

            Console.ReadKey();
        }
    }
}
