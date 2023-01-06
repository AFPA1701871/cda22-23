using System;
using System.Collections.Generic;

#nullable disable

namespace EF_Relations.Data.Models
{
    public partial class Commande
    {
        public Commande()
        {
            Contenus = new HashSet<Contenu>();
        }

        public int IdCommande { get; set; }
        public string LibelleCommande { get; set; }

        public virtual ICollection<Contenu> Contenus { get; set; }
    }
}
