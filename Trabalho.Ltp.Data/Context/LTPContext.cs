using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Trabalho.LTP.Dominio.ItensRoot;

namespace Trabalho.Ltp.Data.Context
{
    public class LTPContext : DbContext

    {

        public LTPContext() : base(ConfigurationManager.ConnectionStrings["StrConexao"].ConnectionString)
        {

        }

        public DbSet<Item> Items { get; set; }

   

    }
}
