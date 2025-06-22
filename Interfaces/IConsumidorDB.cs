using System.Collections.Generic;

namespace ControleDeLuz
{
    /// Define o contrato para as operações de banco de dados da entidade Consumidor.
    public interface IConsumidorDB
    {
        void Adicionar(Consumidor consumidor);
        Consumidor BuscarPorDocumento(string documento);
        List<Consumidor> ListarTodos();
    }
}
