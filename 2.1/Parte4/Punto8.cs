using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabSintaxis2.Parte4
{
    public class Punto8
    {
        public static void Punto()
        {
            int intentos = 0;
            string clave, intent;
            clave = "antestodoeramejor";
            while (intentos < 4)
            {
                intentos++;
                Console.WriteLine("Intento numero {0}", intentos);
                Console.WriteLine("Introduzca la clave: ");
                intent = Console.ReadLine();
                if (clave == intent)
                {
                    Console.WriteLine("Clave correcta, bien hecho!!");
                    Console.WriteLine();
                    Console.ReadKey();
                    Console.Clear();
                    Console.WriteLine("Saliendo...");
                    Console.ReadKey();
                    break;
                }
                else
                {
                    Console.WriteLine("Contraseña incorrecta");
                    Console.Clear();
                }
            }
        }
    }
}
