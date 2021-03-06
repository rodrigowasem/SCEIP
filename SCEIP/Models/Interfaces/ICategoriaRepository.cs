using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SCEIP.Models.Interfaces
{
    public interface ICategoriaRepository
    {
        Categoria GetCategoriaById(int id);
        IQueryable<Categoria> GetAll();
    }
}
