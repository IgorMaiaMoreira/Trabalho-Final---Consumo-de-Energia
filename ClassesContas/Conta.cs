public abstract class Conta
{
    public int NumeroInstalacao { get; set; }
    public double LeituraMesAnterior { get; set; }
    public double LeituraMesAtual { get; set; }
    public Consumidor Titular { get; set; } // Associação com a classe Cliente
    
    public const double ILUMINACAO_PUBLICA = 9.25;

    // Construtor
    public Conta(int numeroInstalacao, Consumidor titular)
    {
        NumeroInstalacao = numeroInstalacao;
        Titular = titular;
    }

    // Método para calcular o consumo, comum a todos os tipos de conta
    public virtual double CalcularConsumoKwh()
    {
        return LeituraMesAtual - LeituraMesAnterior;
    }

    // Métodos abstratos que serão implementados pelas classes filhas
    public abstract double CalcularValorTotal();
    public abstract double CalcularValorSemImpostos();
}