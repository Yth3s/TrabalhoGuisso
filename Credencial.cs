using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using System.Security.Cryptography;

namespace TrabalhoGuisso
{
    [Table("tbl_credencial")]
    public class Credencial
    {
        public const String SALT = "1FnM6_";

        private Usuario _usuario;
        private String _senha;

        public Int64 Id { get; set; }

        public String Senha 
        {
            get => _senha;
            set 
            {
                _senha = ComputeSHA256(value,SALT);
            } 
        }

        public Boolean Gerente { get; set; }

        public DateTime UltimoAcesso { get; set; }

        public Usuario Usuario { get; set; }

        public static String ComputeSHA256(String input, String salt)
        {
            String hash = String.Empty;

            // Initialize a SHA256 hash object
            using (SHA256 sha256 = SHA256.Create())
            {
                // Compute the hash of the given string
                byte[] hashValue = sha256.ComputeHash(
                    Encoding.UTF8.GetBytes(salt + input));

                // Convert the byte array to string format
                foreach (byte b in hashValue)
                {
                    hash += $"{b:X2}";
                }
            }

            return hash;
        }
    }
}
