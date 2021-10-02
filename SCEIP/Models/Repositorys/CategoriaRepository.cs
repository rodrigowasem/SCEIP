using SCEIP.Models.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SCEIP.Models.Repositorys
{
    public class CategoriaRepository : ICategoriaRepository
    {
        private readonly AppDbContext _context;

        public CategoriaRepository(AppDbContext context)
        {
            _context = context;
        }

        public IQueryable<Categoria> GetAll()
        {
            return _context.Categorias;
        }

        public Categoria GetCategoriaById(int id)
        {
            return _context.Categorias.FirstOrDefault(x => x.Id == id);
        }
    }
}
