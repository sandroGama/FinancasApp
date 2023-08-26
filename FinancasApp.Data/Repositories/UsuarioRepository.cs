using FinancasApp.Data.Contexts;
using FinancasApp.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinancasApp.Data.Repositories
{
    public class UsuarioRepository
    {
        public void Create(Usuario usuario)
        {
            using (var dataContext = new DataContext())
            {
                dataContext.Add(usuario);
                dataContext.SaveChanges();
            }
        }

        public void Update(Usuario usuario)
        {
            using (var dataContext = new DataContext())
            {
                dataContext.Update(usuario);
                dataContext.SaveChanges();
            }
        }

        public void Delete(Usuario usuario)
        {
            using (var dataContext = new DataContext())
            {
                dataContext.Remove(usuario);
                dataContext.SaveChanges();
            }
        }

        public List<Usuario> GetAll()
        {
            using (var dataContext = new DataContext())
            {
                return dataContext.Usuario
                .OrderBy(u => u.Nome)
                .ToList();
            }
        }

        public Usuario? GetById(Guid id)
        {
            using (var dataContext = new DataContext())
            {
                return dataContext.Usuario
                    .Where(u => u.Id == id)
                    .FirstOrDefault();
            }
        }

        public Usuario? GetByEmail(string email)
        {
            using (var dataContext = new DataContext())
            {
                return dataContext.Usuario
                    .Where(u => u.Email == email)
                    .FirstOrDefault();
            }
        }

        public Usuario? GetByEmailAndSenha(string email, string senha)
        {
            using (var dataContext = new DataContext())
            {
                return dataContext.Usuario
                    .Where (u => u.Email == email && u.Senha == senha)
                    .FirstOrDefault();
            }
        }
            
        
            
        

    }
}
