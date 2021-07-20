using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_U2_C3_2._3
{
    public class Paso1
    {
        public static void PasoProvincia()
        {
            var prov = new List<Provincia>()
            {
                new Provincia("Santa Fe"),
                new Provincia("Buenos Aires"),
                new Provincia("Capital Federal"),
                new Provincia("Catamarca"),
                new Provincia("Chaco"),
                new Provincia("Chubut"),
                new Provincia("Cordoba"),
                new Provincia("Corrientes"),
                new Provincia("Entre Rios"),
                new Provincia("Formosa"),
                new Provincia("Jujuy"),
                new Provincia("La Pampa"),
                new Provincia("Mendoza"),
                new Provincia("Misiones"),
                new Provincia("Neuquen"),
                new Provincia("Rio Negro"),
                new Provincia("Salta"),
                new Provincia("San Juan"),
                new Provincia("San Luis"),
                new Provincia("Santa Cruz"),
                new Provincia("Santiago del Estero"),
                new Provincia("Tierra del Fuego"),
                new Provincia("Tucuman")
            };              
            var provConST = from p in prov
                            where p.NombreProvincia.StartsWith("S") || p.NombreProvincia.StartsWith("T")
                            select p;
            foreach (Provincia pro in provConST)
            {
                Console.WriteLine(pro.NombreProvincia);
            }
        }
    }
}
