using System;

namespace ControleDeLuz
{
    public class ContaFactory : IContaFactory
    {
        public IConta CriarConta(string tipoConta, int numeroInstalacao, double leituraMesAnterior, double leituraMesAtual, Consumidor titular)
        {
            switch (tipoConta.ToLower())
            {
                case "residencial":
                    return new ContaResidencial(numeroInstalacao, titular, leituraMesAnterior, leituraMesAtual);
                case "comercial":
                    return new ContaComercial(numeroInstalacao, titular, leituraMesAnterior, leituraMesAtual);
                default:
                    // Lança uma exceção se um tipo desconhecido for passado.
                    throw new ArgumentException("Tipo de conta inválido fornecido.", nameof(tipoConta));
            }
        }
    }
}