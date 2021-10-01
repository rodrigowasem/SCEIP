using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SCEIP.Models.Interfaces
{
    public interface IEmprestimoRepository
    {
        IEnumerable<Emprestimo> Emprestimos { get; }
        void AdicionaEmprestimo(Emprestimo emprestimo);
        void Update(Emprestimo emprestimo);
    }

}
