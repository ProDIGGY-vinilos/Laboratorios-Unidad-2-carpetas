using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_U2_C3_2._3
{
    class Paso4
    {
        public static void AltEmpl()
        {
            int opc = 1, id;            
            string nombre;
            decimal sueldo;
            var emple = new List<Empleado>
            {
                new Empleado(2,"Cristian Gerster",55700),
                new Empleado(1,"Roberto Gerster",125000),
                new Empleado(3,"Ana Carradori",87000),
                new Empleado(4,"Este Fi", 100000),
                new Empleado(5,"Robe Rto",15855),
                new Empleado(6,"Pablo Ger",750855),
            };
            while (opc != 0)
            {
                Console.WriteLine("1- Alta ");
                Console.WriteLine("2- Lista ordenada Ascendente");
                Console.WriteLine("3- Lista ordenada Descentende");
                Console.WriteLine("0- Salir");
                opc = int.Parse(Console.ReadLine());

                switch (opc)
                {
                    case 1:
                        Console.WriteLine("Ingrese el nombre del empleado nuevo");
                        nombre = Console.ReadLine();
                        Console.WriteLine("Ingrese Sueldo");
                        sueldo = decimal.Parse(Console.ReadLine());
                        id = emple.Max(x => x.Idd);
                        id = 1 + id;
                        emple.Add(new Empleado(id, nombre, sueldo));
                        break;
                    case 2:
                        var empleAsc = emple.OrderBy(x => x.Sueld).ToList();
                        foreach (Empleado e in empleAsc)
                        {
                            Console.WriteLine(e.Idd + " / " + e.Nombr + " / " + e.Sueld);
                        }
                        break;
                    case 3:
                        var empleDes = emple.OrderByDescending(x => x.Sueld).ToList();
                        foreach (Empleado e in empleDes)
                        {
                            Console.WriteLine(e.Idd + " / " + e.Nombr + " / " + e.Sueld);
                        }
                        break;
                    default:
                        break;
                }
            }


        }
       
    }
}
