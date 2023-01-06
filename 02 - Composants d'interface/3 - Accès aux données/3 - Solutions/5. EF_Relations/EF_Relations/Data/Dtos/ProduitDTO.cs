using EF_Relations.Data.Models;
using System;
using System.Collections.Generic;

#nullable disable

namespace EF_Relations.Data.Dtos
{
    public partial class ProduitsDTO
    {
        public ProduitsDTO()
        {
         }

        public int IdProduit { get; set; }
        public string LibelleProduit { get; set; }

       }
    public partial class ProduitsDTOAvecListeCommandes
    {
        public ProduitsDTOAvecListeCommandes()
        {
            Contenus = new HashSet<ContenuDTOAvecCdes>();
        }

        public int IdProduit { get; set; }
        public string LibelleProduit { get; set; }

        public virtual ICollection<ContenuDTOAvecCdes> Contenus { get; set; }
        public virtual ICollection<CommandeDTO> ListeCommandes { get; set; }
    }
}
