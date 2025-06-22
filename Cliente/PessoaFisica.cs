public class PessoaFisica : Consumidor
{
    public string CPF { get; set; }

    public override string ObterDocumento() => CPF;
}