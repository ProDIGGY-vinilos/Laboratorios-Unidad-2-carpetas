using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabSintaxis2.Parte4
{
    public class Punto5
    {
        public static void Punto()
        {
            string[] mes = new string[12] { "enero", "febrero", "marzo", "abril", "mayo", "junio", "julio", "agosto", "septiembre", "octubre", "noviembre", "diciembre" };
            string mesIngresado;
            Console.WriteLine("Ingrese un mes: "); mesIngresado = Console.ReadLine().ToLower();
            for (int i = 0; i < mes.Length ; i++)
            {
                if (mes[i] == mesIngresado)
                {
                    Console.WriteLine("Mes ingresado: {0} + {1}", mes[i], (i+1));
                }
            }
            Console.ReadKey();
        }
    }
}
