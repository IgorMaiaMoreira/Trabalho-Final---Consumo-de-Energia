
namespace ControleDeLuz
{
    public abstract class ContaBase : IConta
    {
        public int NumeroInstalacao { get; set; }
        public double LeituraMesAnterior { get; set; }
        public double LeituraMesAtual { get; set; }
        public Consumidor Titular { get; set; }

        protected ContaBase(int numeroInstalacao, Consumidor titular, double leituraMesAnterior, double leituraMesAtual)
        {
            this.NumeroInstalacao = numeroInstalacao;
            this.Titular = titular;
            this.LeituraMesAnterior = leituraMesAnterior;
            this.LeituraMesAtual = leituraMesAtual;
        }

        public virtual double CalcularConsumoKwh()
        {
            return LeituraMesAtual - LeituraMesAnterior;
        }

        // Força as classes filhas a implementarem seus próprios cálculos.
        public abstract double CalcularValorTotal();
        public abstract double CalcularValorSemImpostos();
    }
}
