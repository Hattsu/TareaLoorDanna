using System;


namespace Ejercicio_aves
{
    class Program
    {

        public static void Main(String[] args)
        {
            IAve condor = new Condor("condorito", "negro");
            IAve gallina = new Gallina("pio", "blanca");
            IAve pato = new Pato("donald", "marron");
            IAve pinguino = new Pinguino("covaski", "gris");

            List<IAve> Ave_lista = new List<IAve>();
            Ave_lista.Add(condor);
            Ave_lista.Add(gallina);
            Ave_lista.Add(pato);
            Ave_lista.Add(pinguino);

            foreach (IAve Aves in ave_lista)
            {
                Aves.Nadar_ave();
                Aves.Volar_ave();
            }


        }

    }
}
