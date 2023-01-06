using System;
using System.Collections.Generic;

#nullable disable

namespace EF_Relations.Data.Models
{
    public partial class Produit
    {
        public Produit()
        {
            Contenus = new HashSet<Contenu>();
        }

        public int IdProduit { get; set; }
        public string LibelleProduit { get; set; }

        public virtual ICollection<Contenu> Contenus { get; set; }
    }
}
