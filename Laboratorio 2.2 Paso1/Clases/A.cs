using System;

namespace Clases
{
    public class A
    {
        

        private string _nombreInstancia;
        //private string txt;

        public string NombreInstancia
        {
            get { return _nombreInstancia; }
            set { _nombreInstancia = value; }
        }
        
        public A(string v)  {    NombreInstancia = v;   }
        public A()  { NombreInstancia = "Instancia sin nombre";  }

        static string MostrarNombre()
        {
            string txt;
            txt = nameof(A);
            return txt;
        }
        public static void M1()
        {
            Console.WriteLine("Metodo M1 invocado");
            Console.ReadKey();
        }
        public static void M2()
        {
            Console.WriteLine("Metodo M2 invocado");
            Console.ReadKey();
        }
        public static void M3()
        {
            Console.WriteLine("Metodo M3 invocado");
            Console.ReadKey();
        }
    }
}
