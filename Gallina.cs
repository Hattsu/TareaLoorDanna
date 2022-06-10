using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicios_aves
{
        public class Gallina : Aves, IAve
        {
            public Gallina(string nombre, string color) : base(nombre, color) { }

            public void Nadar_ave()
            {
                Console.WriteLine("-------------------");
                Console.WriteLine("");
                Console.WriteLine("El nombre es " + Nombre);
                Console.WriteLine("EL color es " + Color);
                Console.WriteLine("");
                Console.WriteLine("-------------------");

            }
            public void Volar_ave()
            {
                Console.WriteLine("-------------------");
                Console.WriteLine("");
                Console.WriteLine("La gallina turuleka" + Nombre);
                Console.WriteLine("Dead");
                Console.WriteLine("");
                Console.WriteLine("-------------------");
            }
        }

}
