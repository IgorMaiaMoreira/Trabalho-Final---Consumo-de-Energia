namespace ControleDeLuz
{
    public interface IContaFactory
    {
        IConta CriarConta(string tipoConta, int numeroInstalacao, Consumidor titular);
    }
}
