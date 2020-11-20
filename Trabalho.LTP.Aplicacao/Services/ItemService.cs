using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Trabalho.Ltp.Data.Interfaces;
using Trabalho.LTP.Aplicacao.Interfaces;
using Trabalho.LTP.Aplicacao.Services.Base;
using Trabalho.LTP.Aplicacao.Validation;
using Trabalho.LTP.Dominio.ItensRoot;

namespace Trabalho.LTP.Aplicacao.Services
{
   public class ItemService: BaseService, IItemServices
    {

        private readonly IItemRepo _repository;

      
       public ItemService(INotificador notificador, IItemRepo repository) : base(notificador)
        {
            _repository = repository;
        }
        public bool Adicionar(Item model)
        {
          if  (!ExecutarValidacao(new ItemValidation(), model))
               return false;

            try
            {
                _repository.Adicionar(model);
                return true;
            }
            catch (Exception ex)
            {
                Notificar("Não foi possível adicionar um novo Item." + ex.Message);

                return false;
            }


          
        }

        public bool Atualizar (Item model)
        {
            if (!ExecutarValidacao(new ItemValidation(), model))
                return false;

            try
            {
                _repository.Atualizar(model);
                return true;
            }
            catch (Exception ex)
            {
                Notificar("Não foi possível Atualizar um novo Item." + ex.Message);

                return false;
            }
        }

        public bool Excluir(int ID)
        {

            
            try
            {
                _repository.Excluir(ID);
                return true;
            }
            catch (Exception ex)
            {
                Notificar("Não foi possível Excluir um Item." + ex.Message);

                return false;
            }
        }
       
    }
}
