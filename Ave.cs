using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicios_aves
{
    public class Aves
    {
        public string Nombre { set; get; }
        public string Color { set; get; }

        public Aves(string nombre, string color)
        {
            this.Nombre = nombre;
            this.Color = color;
        }
    }
}
