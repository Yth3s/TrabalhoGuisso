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
        public Int64 Id { get; set; }
        public String Nome { get; set; }
        public String Telefone { get; set; }
        public String Gmail { get; set; }
        [ForeignKey("Credencial_Id")]
        [Unicode]
        public Credencial Credencial { get; set; }
    }
}
