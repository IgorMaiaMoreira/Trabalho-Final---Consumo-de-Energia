namespace ControleDeLuz
{
    /// <summary>
    /// Define o contrato para qualquer tipo de conta de energia.
    /// </summary>
    public interface IConta
    {
        int NumeroInstalacao { get; set; }
        double LeituraMesAnterior { get; set; }
        double LeituraMesAtual { get; set; }
        Consumidor Titular { get; set; }

        double CalcularConsumoKwh();
        double CalcularValorTotal();
        double CalcularValorSemImpostos();
    }
}
