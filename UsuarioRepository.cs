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
        public static void SaveOrUpdate(Usuario u) 
        {
            try
            {
                using (Repository DbContext = new Repository()) 
                {
                    if (u.Id == 0)
                    {
                        DbContext.Usuarios.Add(u);
                    }
                    else 
                    {
                        DbContext.Entry(u).State = EntityState.Modified;
                    }
                    DbContext.SaveChanges();
                }
            }
            catch(Exception)
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
