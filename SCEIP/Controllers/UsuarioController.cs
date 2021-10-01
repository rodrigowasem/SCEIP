using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SCEIP.Controllers
{
    public class UsuarioController : Controller
    {
        public IActionResult Cadastrar()
        {
            return View();
        }
    }
}
