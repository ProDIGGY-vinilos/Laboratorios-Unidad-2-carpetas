using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_U2_C3_2._3
{
    class Paso3
    {
        public static void MostrarCod()
        {
            var ciudades = new List<Ciudades>
            {
                new Ciudades(2005,"Cañada de Gomez"),
                new Ciudades(2000, "Rosario"),
                new Ciudades(2144,"Totoras"),
                new Ciudades(2503,"Villa Eloisa"),
                new Ciudades(7605,"Mar del Plata"),
                new Ciudades(2600,"Venado Tuerto"),
                new Ciudades(1900,"La Plata"),
                new Ciudades(5152,"Villa Carlos Paz"),
                new Ciudades(3400,"Corrientes"),
                new Ciudades(3016,"Santo Tome"),
                new Ciudades(2152,"Granadero Baigorria"),
            };
            string ciu;
            Console.WriteLine("Por favor escriba la ciudad a buscar");
            ciu = Console.ReadLine().ToLower();
            var codciu = from nom in ciudades
                         where nom.Nombre.ToLower().Contains(ciu)
                         select nom;
            foreach (Ciudades nom in codciu)
            {
                Console.WriteLine(nom.Codigo);
            }
            Console.ReadKey();            
        }
    }
}
