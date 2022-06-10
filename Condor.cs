using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ave
{
    public class Condor : Ave, iAve
    {
        public Condor(string nombre, string color) : base(nombre, color) { }
        public void nadar_AVE()
        {

            Console.WriteLine("-------------------");
            Console.WriteLine("");
            Console.WriteLine("El nombre es " + nombre);
            Console.WriteLine("El color es " + color);
            Console.WriteLine("");
            Console.WriteLine("-------------------");

        }
        public void volar_AVE()
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
