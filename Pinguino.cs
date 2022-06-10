using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ave
{
    class Pinguino
    {
        public class Pinguino : Ave, iAve
        {
            public Pinguino(string nombre, string color) : base(nombre, color) { }

            public void nadar_AVE()
            {
                Console.WriteLine("-------------------");
                Console.WriteLine("");
                Console.WriteLine("El Nombre es" + nombre);
                Console.WriteLine("El color es" + color);
                Console.WriteLine("-------------------");
                Console.WriteLine("");

            }
            public void volar_AVE()
            {
                Console.WriteLine("-------------------");
                Console.WriteLine("");
                Console.WriteLine("Covasqui" + nombre);
                Console.WriteLine("solo aleteo");
                Console.WriteLine("-------------------");
                Console.WriteLine("");
            }
        }
    }
}
