using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Trabalho.LTP.Aplicacao.Notificacoes;

namespace Trabalho.LTP.Aplicacao.Interfaces
{
   public interface INotificador
    {
        void Handle(Notificacao notificacao);

        List<Notificacao> ObterNotificacoes();

        bool TemNotificacao();
    }
}
