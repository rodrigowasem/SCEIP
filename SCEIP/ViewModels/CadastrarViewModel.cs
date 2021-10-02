using SCEIP.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SCEIP.ViewModels
{
    public class CadastrarViewModel
    {
        public Item Item { get; set; }
        public IEnumerable<Categoria> Categorias { get; set; }
        public IEnumerable<Usuario> Usuarios { get; set; }
    }
}
