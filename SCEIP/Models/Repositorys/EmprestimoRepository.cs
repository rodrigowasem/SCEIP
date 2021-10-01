using SCEIP.Models.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SCEIP.Models.Repositorys
{
    public class EmprestimoRepository : IEmprestimoRepository
    {
        private readonly AppDbContext _context;

        public EmprestimoRepository(AppDbContext context)
        {
            _context = context;
        }

        // busca todos os empréstimos existentes na tabela do banco
        public IEnumerable<Emprestimo> Emprestimos { get => _context.Emprestimos; }

        // 
        public void AdicionaEmprestimo(Emprestimo emprestimo)
        {
            //Adiciona o novo emprestimo
            _context.Emprestimos.Add(emprestimo);
            //Salva as alterações de _context no banco
            _context.SaveChanges();

        }

        public void Update(Emprestimo emprestimo)
        {
            _context.Emprestimos.Update(emprestimo);
            _context.SaveChanges();
        }

    }
}
