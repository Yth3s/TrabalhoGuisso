using System;
using System.Collections.Generic;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Storage;

namespace TrabalhoGuisso
{
    public class Repository : DbContext
    {
        private Usuario _admin;
        private Credencial _adminCredencial;
        private static readonly String _connectionParams = @"uid=root;pwd=;server=127.0.0.1;database=JacintoPinto;port=3307";

        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<Credencial> Credenciais { get; set; }
        public Repository() 
        {
            if (Database.EnsureCreated()) 
            {
                Credencial _adminCredencial = new Credencial() { Senha = "000000", Gerente = true };
                Usuario _admin = new Usuario() { Nome = "Admin", Gmail = "", Telefone = "", Credencial = _adminCredencial };
                UsuarioRepository.SaveOrUpdate(_admin);
            }
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsbuilder)
        {
            base.OnConfiguring(optionsbuilder);
            optionsbuilder.UseMySQL(_connectionParams);
        }
    }
}
