using SCEIP.Models;
using SCEIP.Models.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SCEIP.Controllers
{
    public class ItemController : Controller
    {
        private readonly IItemRepository _repository;
        private readonly ICategoriaRepository _categoriaRepository;
        private readonly IUsuarioRepository _usuarioRepository;
        private readonly IEmprestimoRepository _emprestimoRepository;

        public ItemController(IItemRepository repository, 
            ICategoriaRepository categoriaRepository, 
            IUsuarioRepository usuarioRepository,
            IEmprestimoRepository emprestimoRepository)
        {
            _repository = repository;
            _categoriaRepository = categoriaRepository;
            _usuarioRepository = usuarioRepository;
            _emprestimoRepository = emprestimoRepository;
        }

        [HttpPost]
        public IActionResult Cadastrar(Item item)
        {
            
            if (ModelState.IsValid)
            {
                item.Categoria = _categoriaRepository.GetCategoriaById(item.CategoriaId);
                item.Usuario = _usuarioRepository.GetUsuarioById(item.UsuarioId);
                _repository.Add(item);
                return RedirectToAction("Home", "Index");
            }

            return View(item);
        }

        public IActionResult FazerEmprestimo(int id)
        {
            var item = _repository.Itens.FirstOrDefault(x => x.Id == id);
            item.Disp_Emprestimo = false;

            Emprestimo novoEmprestimo = new Emprestimo()
            {
                
            };


            //_emprestimoRepository.AdicionaEmprestimo(emprestimo);
            //_itemRepository.Update(emprestimo.Item);

            return View("Index");           
        }
    }
}
