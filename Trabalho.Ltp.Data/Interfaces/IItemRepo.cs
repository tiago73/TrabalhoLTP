using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Trabalho.LTP.Dominio.ItensRoot;

namespace Trabalho.Ltp.Data.Interfaces
{
   public interface IItemRepo
    {
        List<Item> ObterTodos();
        void Adicionar(Item model);

        void Atualizar(Item model);
        void Excluir(int ID);
        Item ObeterPorId(int ID);



    }
}
