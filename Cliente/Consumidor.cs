// Classe base abstrata
public abstract class Consumidor
{
    public int Id { get; set; } // Chave primária para o banco de dados
    public string Nome { get; set; }
    
    // Propriedade abstrata para garantir que toda especialização tenha um documento
    public abstract string ObterDocumento();
}
