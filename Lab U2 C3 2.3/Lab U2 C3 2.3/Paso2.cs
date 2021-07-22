using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_U2_C3_2._3
{
    class Paso2
    {
        public static void SeleccionNum()
        {
            int num;
            var numer = new List<Numeros> { };
            Console.WriteLine("Ingrese la secuencia de numero a almacenar");
            Console.WriteLine("Ingrese 0 para terminar");
            num = int.Parse(Console.ReadLine());
            while (num != 0)
            {                               
                numer.Add(new Numeros(num));
                num = int.Parse(Console.ReadLine());               
            }

            Console.WriteLine("A continuacion se mostraran todos aquellos que sean mayor a 20");
            Console.ReadKey();
            var numMay = from nu in numer
                         where nu.Numero > 20
                         select nu;
            foreach (Numeros nums in numMay)
            {
                Console.Write(nums.Numero + " ");
            }

        }
    }
}
