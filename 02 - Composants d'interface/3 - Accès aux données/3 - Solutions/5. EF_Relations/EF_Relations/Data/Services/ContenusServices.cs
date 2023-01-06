using EF_Relations.Data.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EF_Relations.Data.Services
{
    public class ContenusServices
    {

        private readonly MyDbContext _context;

        public ContenusServices(MyDbContext context)
        {
            _context = context;
        }

        public void AddContenu(Contenu obj)
        {
            if (obj == null)
            {
                throw new ArgumentNullException(nameof(obj));
            }
            _context.Contenus.Add(obj);
            _context.SaveChanges();
        }

        public void DeleteContenu(Contenu obj)
        {
            if (obj == null)
            {
                throw new ArgumentNullException(nameof(obj));
            }
            _context.Contenus.Remove(obj);
            _context.SaveChanges();
        }

        public IEnumerable<Contenu> GetAllContenus()
        {
            return _context.Contenus.Include("Cde").Include("Prod").ToList();
        }

        public Contenu GetContenuById(int idProduit, int idCommande)
        {
            return _context.Contenus.Include("Cde").Include("Prod").FirstOrDefault(obj => obj.IdProduit == idProduit && obj.IdCommande==idCommande);
        }

        public void UpdateContenu(Contenu obj)
        {
            _context.SaveChanges();
        }


    }
}
