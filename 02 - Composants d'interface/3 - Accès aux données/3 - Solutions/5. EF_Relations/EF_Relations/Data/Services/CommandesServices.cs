using EF_Relations.Data.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EF_Relations.Data.Services
{
    public class CommandesServices
    {

        private readonly MyDbContext _context;

        public CommandesServices(MyDbContext context)
        {
            _context = context;
        }

        public void AddCommande(Commande obj)
        {
            if (obj == null)
            {
                throw new ArgumentNullException(nameof(obj));
            }
            _context.Commandes.Add(obj);
            _context.SaveChanges();
        }

        public void DeleteCommande(Commande obj)
        {
            if (obj == null)
            {
                throw new ArgumentNullException(nameof(obj));
            }
            _context.Commandes.Remove(obj);
            _context.SaveChanges();
        }

        public IEnumerable<Commande> GetAllCommandes()
        {
            return _context.Commandes.Include("Contenus.Prod").ToList();
        }

        public Commande GetCommandeById(int id)
        {
            return _context.Commandes.Include("Contenus.Prod").FirstOrDefault(obj => obj.IdCommande == id);
        }

        public void UpdateCommande(Commande obj)
        {
            _context.SaveChanges();
        }


    }
}
