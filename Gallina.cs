using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ave
{
        public class Gallina : Ave, iAve
        {
            public Gallina(string nombre, string color) : base(nombre, color) { }

            public void nadar_AVE()
            {
                Console.WriteLine("-------------------");
                Console.WriteLine("");
                Console.WriteLine("El nombre es " + nombre);
                Console.WriteLine("EL color es " + color);
                Console.WriteLine("");
                Console.WriteLine("-------------------");

            }
            public void volar_AVE()
            {
                Console.WriteLine("-------------------");
                Console.WriteLine("");
                Console.WriteLine("La gallina turuleka" + nombre);
                Console.WriteLine("Dead");
                Console.WriteLine("");
                Console.WriteLine("-------------------");
            }
        }

}
