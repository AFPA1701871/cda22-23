using System;
using System.Collections.Generic;

#nullable disable

namespace EF_Relations.Data.Models
{
    public partial class Contenu
    {
        public int IdProduit { get; set; }
        public int IdCommande { get; set; }
        public int Quantite { get; set; }

        public virtual Commande Cde { get; set; }
        public virtual Produit Prod { get; set; }
    }
}
