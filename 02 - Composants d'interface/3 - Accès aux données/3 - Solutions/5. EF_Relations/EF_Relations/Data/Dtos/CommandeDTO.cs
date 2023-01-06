using EF_Relations.Data.Models;
using System;
using System.Collections.Generic;

#nullable disable

namespace EF_Relations.Data.Dtos
{
    public partial class CommandeDTO
    {
        public CommandeDTO()
        {
        }

        public int IdCommande { get; set; }
        public string LibelleCommande { get; set; }

    }
    public partial class CommandeDTOAvecContenu
    {
        public CommandeDTOAvecContenu()
        {
             Contenus = new HashSet<ContenuDTOAvecProds>();
        }

        public int IdCommande { get; set; }
        public string LibelleCommande { get; set; }

         public virtual ICollection<ContenuDTOAvecProds> Contenus { get; set; }
    }
    public partial class CommandeDTOAvecListeProduits
    {
        public CommandeDTOAvecListeProduits()
        {
            Contenus = new HashSet<ContenuDTOAvecProds>();
        }

        public int IdCommande { get; set; }
        public string LibelleCommande { get; set; }

        public virtual ICollection<ContenuDTOAvecProds> Contenus { get; set; }
        public virtual ICollection<ProduitsDTO> ListeProduits { get; set; }
    }
}
