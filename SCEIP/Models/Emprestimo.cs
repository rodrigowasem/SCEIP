using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SCEIP.Models
{
    public class Emprestimo
    {
        public int Id { get; set; }
        public int UsuarioId { get; set; }
        public int ItemId { get; set; }
        public DateTime Data_Emprestimo { get; set; }
        public DateTime Data_Devolucao { get; set; }
    }
}
