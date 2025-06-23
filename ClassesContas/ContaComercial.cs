namespace ControleDeLuz
{
    public class ContaComercial : ContaBase{
        private const double TARIFA_COMERCIAL = 0.35;
        private const double IMPOSTO_COMERCIAL = 0.18; // 18%
        private const double ILUMINACAO_PUBLICA = 9.25;

        public ContaComercial(int numeroInstalacao, Consumidor titular, double leituraMesAnterior, double leituraMesAtual) : base(numeroInstalacao, titular, leituraMesAnterior, leituraMesAtual) { }

        public override double CalcularValorSemImpostos(){
            double valorConsumo = CalcularConsumoKwh() * TARIFA_COMERCIAL;
            return valorConsumo + ILUMINACAO_PUBLICA;
        }

        public override double CalcularValorTotal(){
            double valorBase = CalcularValorSemImpostos();
            double valorImposto = valorBase * IMPOSTO_COMERCIAL;
            return valorBase + valorImposto;
        }
    }
}
