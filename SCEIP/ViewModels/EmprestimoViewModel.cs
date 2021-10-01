using SCEIP.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SCEIP.ViewModels
{
    public class EmprestimoViewModel
    {
        public string Busca { get; set; }
        public IEnumerable<Emprestimo> Emprestimos { get; set; }
    }
}
