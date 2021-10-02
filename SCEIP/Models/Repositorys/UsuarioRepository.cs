using SCEIP.Models.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SCEIP.Models.Repositorys
{
    public class UsuarioRepository : IUsuarioRepository
    {
        private readonly AppDbContext _context;

        public UsuarioRepository(AppDbContext context)
        {
            _context = context;
        }

        public IQueryable<Usuario> GetAll()
        {
            return _context.Usuarios;
        }

        public Usuario GetUsuarioById(int id)
        {
            return _context.Usuarios.FirstOrDefault(x => x.Id == id);
        }
    }
}
