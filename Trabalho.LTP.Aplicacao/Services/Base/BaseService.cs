using FluentValidation;
using FluentValidation.Results;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Trabalho.LTP.Aplicacao.Interfaces;
using Trabalho.LTP.Aplicacao.Notificacoes;

namespace Trabalho.LTP.Aplicacao.Services.Base
{
    public abstract class BaseService : IBaseService
    {
        private readonly INotificador _notificador;

        public BaseService(INotificador notificador)
        {
            _notificador = notificador;
        }

        protected void Notificar(ValidationResult validationResult)
        {
            foreach (var error in validationResult.Errors)
            {
                Notificar(error.ErrorMessage);
            }
        }

        protected void Notificar(string mensagem)
        {
            _notificador.Handle(new Notificacao(mensagem));
        }

        protected void Notificar(string mensagem, params object[] parametros)
        {
            _notificador.Handle(new Notificacao(string.Format(mensagem, parametros)));
        }

        protected bool ExecutarValidacao<TV, TE>(TV validacao, TE entidade)
            where TE : class
            where TV : AbstractValidator<TE>
        {
            var validator = validacao.Validate(entidade);

            if (validator.IsValid) return true;

            Notificar(validator);

            return false;
        }

        public string ObterNotificacoes()
        {
            string retorno = string.Empty;

            _notificador.ObterNotificacoes().ForEach(n => retorno += n.Mensagem + " \n\n");

            return retorno;


        }
    }
}
