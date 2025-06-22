namespace ControleDeLuz
{
    public class ContaResidencial : ContaBase{
        private const double TARIFA_RESIDENCIAL = 0.40;
        private const double IMPOSTO_RESIDENCIAL = 0.30; // 30%
        private const double ILUMINACAO_PUBLICA = 9.25;

        public ContaResidencial(int numeroInstalacao, Consumidor titular) : base(numeroInstalacao, titular) { }

        public override double CalcularValorSemImpostos(){
            double valorConsumo = CalcularConsumoKwh() * TARIFA_RESIDENCIAL;
            return valorConsumo + ILUMINACAO_PUBLICA;
        }

        public override double CalcularValorTotal(){
            double valorBase = CalcularValorSemImpostos();
            double valorImposto = valorBase * IMPOSTO_RESIDENCIAL;
            return valorBase + valorImposto;
        }
    }
}
