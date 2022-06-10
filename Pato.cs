using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicios_aves
{
    public class Pato : Aves, IAve

    {
        public Pato(string nombre, string color) : base(nombre, color) { }

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
            Console.WriteLine("Pato Donalt" + Nombre);
            Console.WriteLine("I BELIVE I CAN FLY");
            Console.WriteLine("");
            Console.WriteLine("-------------------");
        }
    }
}
