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
            Console.WriteLine("El nombre es " + nombre);
            Console.WriteLine("El color es " + color);
            Console.WriteLine("");
            Console.WriteLine("-------------------");

        }
        public void Volar_ave()
        {
            Console.WriteLine("-------------------");
            Console.WriteLine("");
            Console.WriteLine("Condorito " + nombre);
            Console.WriteLine("*vuela*");
            Console.WriteLine("");
            Console.WriteLine("-------------------");
        }
    }
}
