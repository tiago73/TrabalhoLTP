using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Trabalho.Ltp.Data.Context;
using Trabalho.Ltp.Data.Interfaces;
using Trabalho.LTP.Dominio.ItensRoot;

namespace Trabalho.Ltp.Data.Repositorios
{
    public class ItemRepo : IItemRepo
    {
      
        private LTPContext _context;

        public ItemRepo(LTPContext context)
        {
            _context = context;
        }
    
        public void Adicionar(Item model)
        {
            _context.Items.Add(model);
            _context.SaveChanges();
        }

        public void Atualizar(Item model)
        {
            _context.Entry(model).State = System.Data.Entity.EntityState.Modified;
            _context.SaveChanges();
        }

        public void Excluir (int ID)
        {
            Item model = _context.Items.Where(a => a.ID == ID).First();
            _context.Items.Remove(model);
            _context.SaveChanges();
        }

        public Item  ObeterPorId(int ID)
        { 
            return _context.Items.Where(a => a.ID == ID).AsNoTracking().First();
        }

        public List<Item> ObterTodos()
        {
            return _context.Items.AsNoTracking().ToList();
        }


    }
}
