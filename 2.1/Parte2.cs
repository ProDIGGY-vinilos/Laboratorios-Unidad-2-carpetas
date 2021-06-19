using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabSintaxis2
{
    public class Parte2
    {
        public static void Parte()
        {
            string inputTexto, opcion;
            int opc;
            Console.WriteLine("Ingrese un texto a analizar2 ");
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
                opcion = Console.ReadLine();
                opc = int.Parse(opcion);
                switch (opc)
                {
                    case 1:
                        Console.WriteLine("Opcion 1 elegida");
                        break;
                    case 2:
                        Console.WriteLine("Opcion 2 elegida");
                        break;
                    case 3:
                        Console.WriteLine("Opcion 3 elegida");
                        break;
                    default:
                        Console.WriteLine("Opcion erronea saliendo...");
                        break;
                }
                Console.ReadKey();
            }
        }
    }
}
