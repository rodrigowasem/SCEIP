using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SCEIP.Models.Interfaces
{
    public interface IItemRepository
    {
        IEnumerable<Item> Itens { get; }
        void Add(Item item);
        void Update(Item item);
        void Remove(Item item);
        IEnumerable<Item> GetItensDispEmprestimo();
    }
}
