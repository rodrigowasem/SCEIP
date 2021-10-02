using SCEIP.Models;
using SCEIP.Models.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.Rendering;

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

        public IActionResult Cadastrar()
        {

            var listaCategorias = _categoriaRepository.GetAll().ToList().Select(x =>
            {
                return new SelectListItem()
                {
                    Text = x.Nome,
                    Value = x.Id.ToString()
                };
            });

            var listaUsuarios = _usuarioRepository.GetAll().ToList().Select(x =>
            {
                return new SelectListItem()
                {
                    Text = x.Nome,
                    Value = x.Id.ToString()
                };
            });

            ViewBag.ListaCategorias = listaCategorias;
            ViewBag.ListaUsuarios = listaUsuarios;

            return View();
        }

        [HttpPost]
        public IActionResult Cadastrar(Item item)
        {

            if (ModelState.IsValid)
            {
                item.Categoria = _categoriaRepository.GetCategoriaById(item.CategoriaId);
                //item.Usuario = _usuarioRepository.GetUsuarioById(item.UsuarioId);
                _repository.Add(item);
                return RedirectToAction("Index", "Home");
            }

            var listaCategorias = _categoriaRepository.GetAll().ToList().Select(x =>
            {
                return new SelectListItem()
                {
                    Text = x.Nome,
                    Value = x.Id.ToString()
                };
            });

            var listaUsuarios = _usuarioRepository.GetAll().ToList().Select(x =>
            {
                return new SelectListItem()
                {
                    Text = x.Nome,
                    Value = x.Id.ToString()
                };
            });

            ViewBag.ListaCategorias = listaCategorias;
            ViewBag.ListaUsuarios = listaUsuarios;

            return View(item);
        }

        public IActionResult FazerEmprestimo(int id)
        {
            var item = _repository.Itens.FirstOrDefault(x => x.Id == id);
            item.Disp_Emprestimo = false;

            Emprestimo novoEmprestimo = new Emprestimo()
            {
                UsuarioId = 1,
                Item = item,
                ItemId = item.Id,
                Data_Emprestimo = DateTime.Now
            };

            _emprestimoRepository.AdicionaEmprestimo(novoEmprestimo);
            _repository.Update(item);

            return RedirectToAction("Index", "Emprestimo");
        }
    }
}
