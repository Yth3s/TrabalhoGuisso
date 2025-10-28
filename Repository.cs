using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace TrabalhoGuisso
{
    public class Repository : DbContext
    {
        private static readonly String _connectionParams = @"uid=root;pwd=;server=127.0.0.1;database=JacintoPinto;port=3307";

        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<Credencial> Credenciais { get; set; }
        public Repository() => Database.EnsureCreated();

        protected override void OnConfiguring(DbContextOptionsBuilder optionsbuilder) 
        {
            base.OnConfiguring(optionsbuilder);
            optionsbuilder.UseMySQL(_connectionParams);
        }

    }
}
