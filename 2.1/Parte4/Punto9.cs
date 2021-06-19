using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabSintaxis2.Parte4
{
    public class Punto9
    {
        public static void Punto()
        {
            
            
            int a = 1;
            Console.WriteLine("Ingrese el numero de filas que desea que tenga el triangulo");          
            
            for (int n = int.Parse(Console.ReadLine()); n > 0; n--)
            {
                string espacio = new string (' ', n);
                string asterisco = new string('*', a);
                a += 2;
                Console.WriteLine(espacio + asterisco);
            }
            Console.ReadKey();
          
        }
    }
}
