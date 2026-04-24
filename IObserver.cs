namespace Amazonia2
{
    // Esta interface define o contrato do CALLBACK.
    // Eu não digo para a PCD qual universidade ela deve chamar, eu digo apenas que ela deve chamar um método chamado "Atualizar".
    public interface IObserver
    {
        // Este método funciona como um CALLBACK. 
        // É uma função que a universidade "deixa" com a PCD para ser chamada de volta quando algo acontecer.
        void Atualizar(string nomePCD, double temp, double ph, double umidade);
    }
}
