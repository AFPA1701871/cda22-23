using AutoMapper;
using EF_Relations.Data.Dtos;
using EF_Relations.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EF_Relations.Data.Profiles
{
    public class CommandesProfile : Profile
    {
        public CommandesProfile()
        {
            CreateMap<Commande, CommandeDTO>();
            CreateMap<Commande, CommandeDTOAvecContenu>();
            CreateMap<Commande, CommandeDTOAvecListeProduits>().ForMember(commDT=>commDT.ListeProduits,o=>o.MapFrom(comm=>comm.Contenus));
            
            // inutile dans ce projet
            CreateMap<CommandeDTO, Commande>();
            CreateMap<CommandeDTOAvecContenu, Commande>();
            CreateMap<CommandeDTOAvecListeProduits, Commande>();
        }
    }
}
