using System;

namespace Amazonia2
{
    public class Universidade : IObserver
    {
        private string _nome;
        public Universidade(string nome) => _nome = nome;

        // O que o OBSERVER faz quando o Callback é acionado?
        // RESPOSTA: Depende do requisito!
        // No meu código, eu apenas imprimo no console, mas eu poderia salvar num log ou mandar um e-mail sem precisar mudar nada na PCD.
        public void Atualizar(string nomePCD, double temp, double ph, double umid)
        {
            Console.WriteLine($"[NOTIFICAÇÃO PARA {_nome}]:");
            Console.WriteLine($"Dados recebidos de {nomePCD} -> Temp: {temp}°C | PH: {ph} | Umidade: {umid}%");
        }
    }
}
