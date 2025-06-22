using System;

namespace ControleDeLuz
{
    public class ContaFactory : IContaFactory
    {
        public IConta CriarConta(string tipoConta, int numeroInstalacao, Consumidor titular)
        {
            switch (tipoConta.ToLower())
            {
                case "residencial":
                    return new ContaResidencial(numeroInstalacao, titular);
                case "comercial":
                    return new ContaComercial(numeroInstalacao, titular);
                default:
                    // Lança uma exceção se um tipo desconhecido for passado.
                    throw new ArgumentException("Tipo de conta inválido fornecido.", nameof(tipoConta));
            }
        }
    }
}