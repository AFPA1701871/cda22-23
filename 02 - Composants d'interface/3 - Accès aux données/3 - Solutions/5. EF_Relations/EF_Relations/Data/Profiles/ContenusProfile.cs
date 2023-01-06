using AutoMapper;
using EF_Relations.Data.Dtos;
using EF_Relations.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EF_Relations.Data.Profiles
{
    public class ContenusProfile : Profile
    {
        public ContenusProfile()
        {
            CreateMap<Contenu, ContenuDTOAvecCdes>();
            CreateMap<ContenuDTOAvecCdes, Contenu>();
            CreateMap<Contenu, ContenuDTOAvecProds>();
            CreateMap<ContenuDTOAvecProds, Contenu>();

            //permet de transférer un contenu en commandeDTO, utiliser dans le remplissage de produit.ListeCommande
            CreateMap<Contenu, CommandeDTO>()
                .ForMember(comm=>comm.IdCommande,act=>act.MapFrom(cont=>cont.IdCommande))
                .ForMember(comm => comm.LibelleCommande, act => act.MapFrom(cont => cont.Cde.LibelleCommande));

            //permet de transférer un contenu en produitDTO, utiliser dans le remplissage de commande.ListeProduit
            CreateMap<Contenu, ProduitsDTO>()
                .ForMember(prod => prod.IdProduit, act => act.MapFrom(cont => cont.IdProduit))
                .ForMember(prod => prod.LibelleProduit, act => act.MapFrom(cont => cont.Prod.LibelleProduit));

        }
    }
}
