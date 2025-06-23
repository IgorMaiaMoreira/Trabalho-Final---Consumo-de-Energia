namespace ControleDeLuz
{
    public interface IContaFactory
    {
        IConta CriarConta(string tipoConta, int numeroInstalacao, double leituraMesAnterior, double leituraMesAtual, Consumidor titular);
    }
}
