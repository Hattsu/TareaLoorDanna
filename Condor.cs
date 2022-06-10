using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicios_aves
{
    public class Condor : Aves, IAve
    {
        public Condor(string nombre, string color) : base(nombre, color) { }
        public void Nadar_ave()
        {

            Console.WriteLine("-------------------");
            Console.WriteLine("");
            Console.WriteLine("El nombre es " + Nombre);
            Console.WriteLine("El color es " + Color);
            Console.WriteLine("");
            Console.WriteLine("-------------------");

        }
        public void Volar_ave()
        {
            Console.WriteLine("-------------------");
            Console.WriteLine("");
            Console.WriteLine("Condorito " + Nombre);
            Console.WriteLine("*vuela*");
            Console.WriteLine("");
            Console.WriteLine("-------------------");
        }
    }
}
