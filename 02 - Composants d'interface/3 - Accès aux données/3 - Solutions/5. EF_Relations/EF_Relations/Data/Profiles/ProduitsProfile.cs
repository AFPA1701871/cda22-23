using AutoMapper;
using EF_Relations.Data.Dtos;
using EF_Relations.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EF_Relations.Data.Profiles
{
    public class ProduitsProfile : Profile
    {
        public ProduitsProfile()
        {
            CreateMap<Produit, ProduitsDTO>();
           CreateMap<Produit, ProduitsDTOAvecListeCommandes>().ForMember(p => p.ListeCommandes, o => o.MapFrom(s => s.Contenus));
            CreateMap<ProduitsDTO, Produit>();
            CreateMap<ProduitsDTOAvecListeCommandes, Produit>();
        }
    }
}
