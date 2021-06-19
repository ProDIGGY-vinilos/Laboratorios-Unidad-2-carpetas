using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabSintaxis2.Parte4
{
    public class Punto2
    {
        public static void Punto()
        {
            int ano;
            string rta;
            Console.WriteLine("Ingrrese el año que quiera verificar si es bisiesto: ");
            ano = int.Parse(Console.ReadLine());

            if (ano%4 == 0)
            {
                if (ano%100 == 0)
                {
                    if (ano%400 == 0)
                    {
                        Console.WriteLine("El año es bisiesto");
                    }
                    else
                    {
                        Console.WriteLine("El año no es bisiesto");
                    }
                }
                else
                {
                    Console.WriteLine("El año es bisiesto");
                }
            }
            else
            {
                Console.WriteLine("El año no es bisiesto");
            }
            Console.WriteLine(); Console.WriteLine(); Console.WriteLine(); Console.WriteLine();
            Console.WriteLine("Volver a calcular? y/n:");
            rta = Console.ReadLine();
            if (rta == "y")
            {
                Punto2.Punto();
            }
            else
            {
                Console.WriteLine("Hasta luego....");
            }
            Console.ReadKey();
        }
    }
}
