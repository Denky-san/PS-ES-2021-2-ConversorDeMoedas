using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TodoList.Models;

namespace TodoList.Data
{
    public class BancoContext : DbContext
    {
        public BancoContext(DbContextOptions<BancoContext> options) : base(options)
        {

        }

        public DbSet<UsuarioModel> Usuarios { get; set; }

        /*
        public DbSet<TarefasModel> Tarefas { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<TarefasModel>()
                .HasOne(p => p.Usuario)
                .WithMany(b => b.Nome)
                .HasForeignKey(p => p.BlogForeignKey);
        }
        */
    }
}
