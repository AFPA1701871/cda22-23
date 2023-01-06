
using AutoMapper;
using EF_Relations.Data.Dtos;
using EF_Relations.Data.Models;
using EF_Relations.Data.Services;
using Microsoft.AspNetCore.JsonPatch;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EF_Relations.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CommandesController:ControllerBase
    {

        private readonly CommandesServices _service;
        private readonly IMapper _mapper;

        public CommandesController(CommandesServices service, IMapper mapper)
        {
            _service = service;
            _mapper = mapper;
        }

        //GET api/Commandes
        [HttpGet]
        public ActionResult<IEnumerable<CommandeDTOAvecListeProduits>> GetAllCommandes()
        {
            IEnumerable<Commande> listeCommandes = _service.GetAllCommandes();
            return Ok(_mapper.Map<IEnumerable<CommandeDTOAvecListeProduits>>(listeCommandes));
        }

        //GET api/Commandes/{i}
        [HttpGet("{id}", Name = "GetCommandeById")]
        public ActionResult<CommandeDTO> GetCommandeById(int id)
        {
            Commande commandItem = _service.GetCommandeById(id);
            if (commandItem != null)
            {
                return Ok(_mapper.Map<CommandeDTO>(commandItem));
            }
            return NotFound();
        }

        //POST api/Commandes
        [HttpPost]
        public ActionResult<CommandeDTO> CreateCommande(Commande objIn)
        {
            Commande obj = _mapper.Map<Commande>(objIn);
            _service.AddCommande(obj);
            return CreatedAtRoute(nameof(GetCommandeById), new { Id = obj.IdCommande }, obj);
        }

        //POST api/Commandes/{id}
        [HttpPut("{id}")]
        public ActionResult UpdateCommande(int id, Commande obj)
        {
            Commande objFromRepo = _service.GetCommandeById(id);
            if (objFromRepo == null)
            {
                return NotFound();
            }
            _mapper.Map(obj, objFromRepo);
            _service.UpdateCommande(objFromRepo);
            return NoContent();
        }

        // Exemple d'appel
        // [{
        // "op":"replace",
        // "path":"",
        // "value":""
        // }]
        //PATCH api/Commandes/{id}
        [HttpPatch("{id}")]
        public ActionResult PartialCommandeUpdate(int id, JsonPatchDocument<Commande> patchDoc)
        {
            Commande objFromRepo = _service.GetCommandeById(id);
            if (objFromRepo == null)
            {
                return NotFound();
            }
            Commande objToPatch = _mapper.Map<Commande>(objFromRepo);
            patchDoc.ApplyTo(objToPatch, ModelState);
            if (!TryValidateModel(objToPatch))
            {
                return ValidationProblem(ModelState);
            }
            _mapper.Map(objToPatch, objFromRepo);
            _service.UpdateCommande(objFromRepo);
            return NoContent();
        }

        //DELETE api/Commandes/{id}
        [HttpDelete("{id}")]
        public ActionResult DeleteCommande(int id)
        {
            Commande obj = _service.GetCommandeById(id);
            if (obj == null)
            {
                return NotFound();
            }
            _service.DeleteCommande(obj);
            return NoContent();
        }


    }
}
