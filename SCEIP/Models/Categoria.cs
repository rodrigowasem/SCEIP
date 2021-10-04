using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SCEIP.Models
{
    public class Categoria
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "O nome deve ser preenchido!")]
        [StringLength(30)]
        public string Nome { get; set; }
    }
}
