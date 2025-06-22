public class ContaFactory : IContaFactory
{
    public Conta CriarConta(string tipoConta, int numeroInstalacao, Consumidor titular)
    {
        switch (tipoConta.ToLower())
        {
            case "residencial":
                return new ContaResidencial(numeroInstalacao, titular);
            case "comercial":
                return new ContaComercial(numeroInstalacao, titular);
            default:
                throw new ArgumentException("Tipo de conta inválido.", nameof(tipoConta));
        }
    }
}