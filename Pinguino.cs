using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_aves
{
    class Pinguino
    {
        public class Pinguino : Aves, iAve
        {
            public Pinguino(string nombre, string color) : base(nombre, color) { }

            public void Nadar_ave()
            {
                Console.WriteLine("-------------------");
                Console.WriteLine("");
                Console.WriteLine("El Nombre es" + Nombre);
                Console.WriteLine("El color es" + Color);
                Console.WriteLine("-------------------");
                Console.WriteLine("");

            }
            public void Volar_ave()
            {
                Console.WriteLine("-------------------");
                Console.WriteLine("");
                Console.WriteLine("Covasqui" + Nombre);
                Console.WriteLine("solo aleteo");
                Console.WriteLine("-------------------");
                Console.WriteLine("");
            }
        }
    }
}
