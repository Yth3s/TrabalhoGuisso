using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace TrabalhoGuisso
{
    [Table("tbl_credencial")]
    public class Credencial
    {
        public Int64 Id { get; set; }
        public String Senha { get; set; }
        public Boolean Gerente { get; set; }
        public DateTime UltimoAcesso { get; set; }
        [ForeignKey("Usuario_Id")]
        [Unicode]
        public Usuario Usuario { get; set; }
    }
}
