using System;
using Clases;   

namespace LabClases1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            A instanciaA = new();
            B instanciaB = new();

            A.M1();
            A.M2();
            A.M3();

            B.M1();
            B.M2();
            B.M3();
            B.M4();

        }
    }
}
