
using EF_Relations.Data.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EF_Relations.Data.Services
{
    public class ProduitsServices
    {

        private readonly MyDbContext _context;

        public ProduitsServices(MyDbContext context)
        {
            _context = context;
        }

        public void AddProduit(Produit obj)
        {
            if (obj == null)
            {
                throw new ArgumentNullException(nameof(obj));
            }
            _context.Produits.Add(obj);
            _context.SaveChanges();
        }

        public void DeleteProduit(Produit obj)
        {
            if (obj == null)
            {
                throw new ArgumentNullException(nameof(obj));
            }
            _context.Produits.Remove(obj);
            _context.SaveChanges();
        }

        public IEnumerable<Produit> GetAllProduits()
        {
            // _context.Produits.ToList();
            // correspond à Select * from produits
            // _context.Produits.Include("Contenus").ToList();
            // correspond à Select * from produits inner join contenus on produit.idProduit = contenus.idProduit (clé primaire double dans Contenu
            return _context.Produits.Include(p=>p.Contenus).ThenInclude(c=>c.Cde).ToList();
        //    return _context.Produits.Include("Contenus.Cde").ToList();
          //  return _context.Produits.Include("Contenus").ToList();
        }

        public Produit GetProduitById(int id)
        {
            return _context.Produits.Include("Contenus").FirstOrDefault(obj => obj.IdProduit == id);
        }

        public void UpdateProduit(Produit obj)
        {
            _context.SaveChanges();
        }


    }
}
