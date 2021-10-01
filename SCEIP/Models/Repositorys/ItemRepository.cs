using SCEIP.Models.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SCEIP.Models.Repositorys
{
    public class ItemRepository : IItemRepository
    {
        private readonly AppDbContext _context;

        public ItemRepository(AppDbContext context)
        {
            _context = context;
        }

        public IEnumerable<Item> Itens { get => _context.Itens; }

        public void Add(Item item)
        {
            _context.Itens.Add(item);
            _context.SaveChanges();
        }

        public void Update(Item item)
        {
            _context.Itens.Update(item);
            _context.SaveChanges();
        }

        public void Remove(Item item)
        {
            _context.Itens.Remove(item);
            _context.SaveChanges();
        }

        public Item GetItemById(int id)
        {
            return _context.Itens.FirstOrDefault(x => x.Id == id);
        }

        public IEnumerable<Item> GetItensDispEmprestimo()
        {
            return _context.Itens.Where(x => x.Disp_Emprestimo == true);
        }
    }
}
