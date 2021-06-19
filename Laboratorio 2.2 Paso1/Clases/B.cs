using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases
{
    public class B : A
    {
        public B():base("Instancia de B") 
        {          }
        public static void M4()
        {
            Console.WriteLine("Metodo M4 del hijo invocado");
            Console.ReadKey();
        }
    }
}
