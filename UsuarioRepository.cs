using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.Marshalling;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace TrabalhoGuisso
{
    public class UsuarioRepository
    {
        public static void Save(Usuario u) 
        {
            try
            {
                using (Repository DbContext = new Repository()) 
                {
                   DbContext.Usuarios.Add(u);
                   DbContext.SaveChanges();
                }
            }
            catch(Exception)
            {
                throw;
            }
        }
        public static void Update(Usuario u)
        {
            try
            {
                using (Repository DbContext = new Repository())
                {
                    DbContext.Entry(u).State = EntityState.Modified;
                    DbContext.SaveChanges();
                }
            }
            catch (Exception)
            {
                throw;
            }
        }
        public static List<Usuario> FindAll() 
        {
            try 
            {
                using (Repository DbContext = new Repository()) 
                {
                    return DbContext.Usuarios.ToList();
                }
            }
            catch
            {
                throw;
            }
        }
    }
}
