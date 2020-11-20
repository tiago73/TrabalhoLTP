using System;
using System.Collections.Generic;
using System.Linq;
using Trabalho.LTP.Aplicacao.Interfaces;

namespace Trabalho.LTP.Aplicacao.Notificacoes
{
   public class Notificador : INotificador
    {
       private List<Notificacao> _notificacao { get; set; }

        public Notificador()
        {
            _notificacao = new List<Notificacao>();
        }

        public void Handle(Notificacao notificacao)
        {

            _notificacao.Add(notificacao);
        }

        public List<Notificacao> ObterNotificacoes()
        {
            return _notificacao;
        }

        public bool TemNotificacao() 
        {
            return _notificacao.Any(); 
        }
    }
}
