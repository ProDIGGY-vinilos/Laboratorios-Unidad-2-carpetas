using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace LabSintaxis2.Parte4
{
    public class Punto7
    {
        public static void Punto()
        {
            int n;
            bool esP, esG;
            Console.WriteLine("Ingrese la cantidad de numeros para calcular los primos gemelos: ");
            Console.WriteLine();
            n = int.Parse(Console.ReadLine());
            for (int i = 1; i <= n; i++)
            {
                esP = true;
                for (int j = 2; j <= i-1; j++)
                {
                    if (i % j == 0)
                    {
                        esP = false;
                        break;
                    }    
                }
                if (esP)
                {
                    esG = Punto7.Esgemelo(i + 2);
                    if (esG)
                    {
                        Console.WriteLine("El numero primo {0} tiene el gemelo {1}", i, (i+2));
              
                    }
                }
            }
            Console.ReadKey();
        }

        static bool Esgemelo (int g)
        {
            for (int i = 0; i <= g; i++)
            {
                for (int j = 2; j <= g-1; j++)
                {
                    if (g % j == 0)
                    {
                        return false;
                    }
                }
            }
            return true;
        }
    }
}
