
using System;
using System.Collections.Generic;

#nullable disable

namespace EF_Relations.Data.Dtos
{
    public partial class ContenuDTOAvecCdes
    {
        public int IdProduit { get; set; }
        public int IdCommande { get; set; }
        public int Quantite { get; set; }

        public virtual CommandeDTO Cde { get; set; }
       // public virtual Produit Prod { get; set; }
    }
    public partial class ContenuDTOAvecProds
    {
        public int IdProduit { get; set; }
        public int IdCommande { get; set; }
        public int Quantite { get; set; }

        //public virtual CommandeDTO Cde { get; set; }
         public virtual ProduitsDTO Prod { get; set; }
    }
}
