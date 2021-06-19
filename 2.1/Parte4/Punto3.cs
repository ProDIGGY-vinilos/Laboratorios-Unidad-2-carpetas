using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabSintaxis2.Parte4
{
    public class Punto3
    {   public static void Punto()
        {
            long n1, n2, aux;
            n1 = 0;
            n2 = 1;
            Console.WriteLine(n1);
            for (int i = 0; i < 50; i++)
            {
                Console.WriteLine(n2);
                aux = n2;
                n2 = n1 + n2;
                n1 = aux;
            }
            Console.ReadKey();
        }
    }
}
