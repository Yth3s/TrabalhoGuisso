using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace TrabalhoGuisso
{
    [Table("tbl_usuario")]
    public class Usuario
    {
        private Credencial _credencial;
        public Int64 Id { get; set; }
        public String Nome { get; set; }
        public String Telefone { get; set; }
        public String Gmail { get; set; }
        [ForeignKey("credencial_id")]
        public Credencial Credencial 
        { 
            get => _credencial; 
            set 
            { 
                value.Usuario = this;
                _credencial = value;
            }
        }
    }
}
