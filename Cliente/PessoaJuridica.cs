namespace ControleDeLuz;
public class PessoaJuridica : Consumidor
{
    public string CNPJ { get; set; }

    public override string ObterDocumento() => CNPJ;
}