using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;

namespace TicketsFechar.Data
{
    public class Context:DbContext
    {
       
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source = 209.126.106.186\SQL2016; Initial Catalog = ProjetoTicket; User ID = ProjetoTicket; Password = projetofinalA#;Persist Security Info=true;");
        }

        public DbSet<Ticket> Tickets { get; set; }
        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<Resposta> Respostas { get; set; }
    }
}
