using System;

using System.Windows.Forms;
using SimpleInjector;
using Trabalho.Ltp.Data.Context;
using Trabalho.Ltp.Data.Interfaces;
using Trabalho.Ltp.Data.Repositorios;
using Trabalho.LTP.Aplicacao.Interfaces;
using Trabalho.LTP.Aplicacao.Notificacoes;
using Trabalho.LTP.Aplicacao.Services;
using Trabalho.LTP.Dominio;

namespace Trabalho.LTP.UI
{
    static class Program
    {

        public static Container container;

        public static void Bootstrap()
        {
            container = new Container();

            container.Register<IItemRepo, ItemRepo>();
            container.Register<LTPContext>(Lifestyle.Singleton);

            container.Register<INotificador, Notificador>();
            container.Register<IItemServices, ItemService>();

            container.Verify();
        }

        /// <summary>
        /// Ponto de entrada principal para o aplicativo.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Bootstrap();
            Application.Run(new Principal());
        }
    }
}
