using System;

namespace Amazonia2
{
    class Program
    {
        static void Main(string[] args)
        {
            // Instanciando os Sujeitos
            PCD pcdManaus = new PCD("PCD-Manaus");

            // Instanciando os Observadores
            Universidade usp = new Universidade("USP");

            // INVERSÃO DE CONTROLE: Eu configuro quem observa quem.
            // A PCD agora tem o "controle" de quando avisar, mas não do que avisar.
            pcdManaus.AdicionarInteressado(usp);

            // Mudança de estado que dispara os Callbacks
            pcdManaus.MedirAgora(32.5, 6.5, 88.0);
        }
    }
}
