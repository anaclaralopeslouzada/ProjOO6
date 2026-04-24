using System;
using System.Collections.Generic;

namespace Amazonia2
{
    public class PCD
    {
        // A PCD não sabe quais universidades estão aqui (USP? UNIFESP?).
        // Ela só sabe que quem estiver na lista segue o contrato IObserver.
        private List<IObserver> _interessados = new List<IObserver>();
        public string Nome { get; }

        public PCD(string nome) => Nome = nome;

        public void AdicionarInteressado(IObserver obs) => _interessados.Add(obs);

        public void MedirAgora(double t, double p, double u)
        {
            // O que o SUBJECT fez aqui? 
            // Ele apenas detectou a mudança e percorreu a lista.
            // POR QUE? Porque a responsabilidade da PCD termina em avisar. 
            // Ela NÃO deve decidir o que a universidade faz com o dado.
            foreach (var interessado in _interessados)
            {
                // Aqui ocorre o CALLBACK: a PCD "chama de volta" o método que a universidade registrou nela.
                interessado.Atualizar(Nome, t, p, u);
            }
        }
    }
}
