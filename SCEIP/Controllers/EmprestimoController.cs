using SCEIP.Models;
using SCEIP.Models.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SCEIP.ViewModels;

namespace SCEIP.Controllers
{
    public class EmprestimoController : Controller
    {
        private readonly IEmprestimoRepository _repository;
        private readonly IItemRepository _itemRepository;

        public EmprestimoController(IEmprestimoRepository repository, 
            IItemRepository itemRepository)
        {
            _repository = repository;
            _itemRepository = itemRepository;
        }
        public IActionResult Index()
        {
            var viewModel = new EmprestimoViewModel()
            {
                Emprestimos = _repository.GetAll()
            };

            return View(viewModel);
        }

        public IActionResult DevolverItem(int id)
        {
            var emprestimo = _repository.Emprestimos.FirstOrDefault(x => x.Id == id);
            emprestimo.Data_Devolucao = DateTime.Now;

            var item = _itemRepository.Itens.FirstOrDefault(x => x.Id == emprestimo.ItemId);
            item.Disp_Emprestimo = true;

            _itemRepository.Update(item);

            _repository.Update(emprestimo);

            return RedirectToAction("Index", "Emprestimo");
        }
    }
}
