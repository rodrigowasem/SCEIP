using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SCEIP.Models
{
    public class AppDbContext : DbContext
    {
        protected override void OnModelCreating(ModelBuilder builder) 
        {
            //builder.Entity<Emprestimo>().HasOne<Usuario>().WithMany().HasForeignKey("UsuarioId").OnDelete(DeleteBehavior.NoAction);
            //builder.Entity<Emprestimo>().HasOne<Item>().WithMany().HasForeignKey("ItemId").OnDelete(DeleteBehavior.NoAction);

            builder.Entity<Emprestimo>().HasOne<Usuario>().WithMany().OnDelete(DeleteBehavior.NoAction);
            builder.Entity<Emprestimo>().HasOne<Item>().WithMany().OnDelete(DeleteBehavior.NoAction);
        }
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) 
        { 
        
        }

        public DbSet<Emprestimo> Emprestimos { get; set; }
        public DbSet<Item> Itens { get; set; }
        public DbSet<Categoria> Categorias { get; set; }
        public DbSet<Usuario> Usuarios { get; set; }

    }
}
