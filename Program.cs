using System;


namespace Ave
{
    class Program
    {

        public static void Main(String[] args)
        {
            iAve condor = new Condor("condorito", "negro");
            iAve gallina = new Gallina("pio", "blanca");
            iAve pato = new Pato("donalt", "maron");
            iAve pinguino = new Pinguino("covaski", "gris");

            List<iAve> ave_lista = new List<iAve>();
            ave_lista.Add(condor);
            ave_lista.Add(gallina);
            ave_lista.Add(pato);
            ave_lista.Add(pinguino);

            foreach (iAve ave in ave_lista)
            {
                ave.nadar_AVE();
                ave.volar_AVE();
            }


        }

    }
}
