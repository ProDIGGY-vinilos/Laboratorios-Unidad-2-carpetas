using System;
using Clases;


namespace LabClases2
{
    class Program
    {
        static void Main(string[] args)
        {
            B b = new();
            A a = b;
            a.F();
            b.F();
            a.G();
            b.G();
        }
    }
}
