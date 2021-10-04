using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SCEIP.Models
{
    public class Usuario
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "O nome deve ser preenchido!")]
        [StringLength(30)]
        public string Nome { get; set; }
        [Required(ErrorMessage = "O sobrenome deve ser preenchido!")]
        [StringLength(50)]
        public string Sobrenome { get; set; }
        [Required(ErrorMessage = "O e-mail deve ser preenchido!")]
        [StringLength(256)]
        public string Email { get; set; }
        [StringLength(12)]
        public string Telefone { get; set; }
        [Required]
        public DateTime DataNasc { get; set; }

}
}
