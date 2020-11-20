using Trabalho.LTP.Dominio.ItensRoot;

namespace Trabalho.LTP.Aplicacao.Interfaces
{
    public  interface IItemServices : IBaseService
    {
        bool Adicionar(Item model);
        bool Atualizar(Item model);
        bool Excluir(int ID);

    }
}
