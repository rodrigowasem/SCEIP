using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SCEIP.Models
{
    public class Item
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "O nome do Item deve ser preenchido!")]
        [StringLength(30)]
        public string Nome { get; set; }
        public Categoria Categoria { get; set; }
        public int CategoriaId { get; set; }
        public bool Disp_Emprestimo { get; set; }
    }
}
