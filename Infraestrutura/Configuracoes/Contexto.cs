using Entidades.Entidades;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infraestrutura.Configuracoes
{
    public class Contexto : IdentityDbContext<ApplicationUser>
    {
        public Contexto (DbContextOptions<Contexto> opcoes) : base(opcoes)
        {  
        }

        public DbSet<Noticia> Noticia {get; set;}

        public dbSet <ApplicationUser> ApplicationUser  { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
         {
            if(!optionsBuilder.IsConfigured)
               {
                 optionsBuilder.UseSqlServer(ObterStringConexao());
                 base.OnConfiguring(optionsBuilder);
               }
         }
         protected override void OnModelCreating(Modelbuilder builder)
         {
            builder.Entity<ApplicationUser>().ToTable("AspNetUser").HasKey(t=> t.Id);
            base.OnModelCreating(builder);
         }
           
        public string ObterStringConexao()
        {
            //stringconnection here
            string strcon = ""
            return strcon;
        }
    }
    
}
