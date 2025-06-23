namespace ControleDeLuz
{
    public abstract class Consumidor
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public int NumeroInstalacao { get; set; }
        public abstract string ObterDocumento();
    }
}