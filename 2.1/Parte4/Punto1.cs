using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabSintaxis2.Parte4
{
    public class Punto1
    {
        public static void Punto()
        {
            int resultado, n1, n2;
            Console.WriteLine("Por favor ingrese los numeros a sumar: ");
            n1 = int.Parse (Console.ReadLine());
            Console.WriteLine("+");
            n2 = int.Parse(Console.ReadLine());
            resultado = n1 + n2;
            Console.WriteLine();
            Console.WriteLine("El resultado de la suma de "+n1+" y "+n2+" es "+resultado);

            Console.ReadKey();
        }
    }
}
