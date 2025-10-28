using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace TrabalhoGuisso
{
    public class CredencialRepository
    {
        public static void SaveOrUpdate(Credencial c) 
        {
            try
            {
                using (Repository DbContext = new Repository()) 
                {
                    if (c.Id == 0)
                    {
                        DbContext.Credenciais.Add(c);
                    }
                    else 
                    {
                        DbContext.Entry(c).State = EntityState.Modified;
                    }
                    DbContext.SaveChanges();
                }
            }
            catch 
            {
                throw; 
            }
        }
        public static List<Credencial> FindAll()
        {
            try 
            {
                using (Repository DbContext = new Repository()) 
                {
                    return DbContext.Credenciais.ToList();
                }
            }
            catch
            {
                throw;
            }
        }
    }

}
