using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabSintaxis2
{
    class Parte3
    {
        public static void Parte()
        {
            string[] textos;
            int[] posiciones = new int[5];
            int cantIteraciones;

            Console.WriteLine("Ingrese cantidad de palabras a ingresar: ");
            cantIteraciones = int.Parse(Console.ReadLine());
            textos = new string[cantIteraciones];
            Console.WriteLine();
            Console.WriteLine("A continuacion ingrese cada una de las palabras: ");
            for (int i = 0; i < cantIteraciones; i++)
            {
                Console.WriteLine();
                Console.WriteLine("Ingrese la palabra num " + i+1 + ": ");
                textos[i] = Console.ReadLine();
                Console.WriteLine();
            }
            Console.WriteLine(); Console.WriteLine(); Console.WriteLine(); Console.WriteLine();
            Console.WriteLine("se mostraran los valores ingresados del ultimo al primero: ");
            Console.WriteLine();
            for (int i = cantIteraciones-1; i >= 0; i--)
            {
                Console.WriteLine("Texto ingresado en la linea "+ (i+1) + ": " + textos[i]);
                Console.WriteLine();
            }



            Console.ReadKey();
        }    
    }
}
