using AutoMapper;
using EF_Relations.Data.Dtos;
using EF_Relations.Data.Models;
using EF_Relations.Data.Services;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EF_Relations.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ContenusController:ControllerBase
    {

        private readonly ContenusServices _service;
        private readonly IMapper _mapper;

        public ContenusController(ContenusServices service, IMapper mapper)
        {
            _service = service;
            _mapper = mapper;
        }

        //GET api/Contenus
        [HttpGet]
        public ActionResult<IEnumerable<ContenuDTOAvecCdes>> GetAllContenus()
        {
            IEnumerable<Contenu> listeContenus = _service.GetAllContenus();
            return Ok(_mapper.Map<IEnumerable<ContenuDTOAvecCdes>>(listeContenus));
        }

        ////GET api/Contenus/{i}
        //[HttpGet("{id}", Name = "GetContenuById")]
        //public ActionResult<ContenuDTO> GetContenuById(int id)
        //{
        //    Contenu commandItem = _service.GetContenuById(id);
        //    if (commandItem != null)
        //    {
        //        return Ok(_mapper.Map<ContenuDTO>(commandItem));
        //    }
        //    return NotFound();
        //}

        //POST api/Contenus
//        [HttpPost]
//        public ActionResult<ContenuDTO> CreateContenu(Contenu objIn)
//        {
//            Contenu obj = _mapper.Map<Contenu>(objIn);
//            _service.AddContenu(obj);
//            return CreatedAtRoute(nameof(GetContenuById), new { Id = obj.IdContenu }, obj);
//=======
//        public ActionResult<ContenuDTO> CreateContenu(Contenu obj)
//        {
//            _service.AddContenu(obj);
//            return CreatedAtRoute(nameof(GetContenuById), new { Id = obj.Id }, obj);
//>>>>>>> ef6f73d5361be19f43c4ab013c17825100b5eea1
//        }

//        //POST api/Contenus/{id}
//        [HttpPut("{id}")]
//<<<<<<< HEAD
//        public ActionResult UpdateContenu(int id, ContenuDTOIn obj)
//=======
//        public ActionResult UpdateContenu(int id, ContenuDTO obj)
//>>>>>>> ef6f73d5361be19f43c4ab013c17825100b5eea1
//        {
//            Contenu objFromRepo = _service.GetContenuById(id);
//            if (objFromRepo == null)
//            {
//                return NotFound();
//            }
//            _mapper.Map(obj, objFromRepo);
//            _service.UpdateContenu(objFromRepo);
//            return NoContent();
//        }

//        // Exemple d'appel
//        // [{
//        // "op":"replace",
//        // "path":"",
//        // "value":""
//        // }]
//        //PATCH api/Contenus/{id}
//        [HttpPatch("{id}")]
//        public ActionResult PartialContenuUpdate(int id, JsonPatchDocument<Contenu> patchDoc)
//        {
//            Contenu objFromRepo = _service.GetContenuById(id);
//            if (objFromRepo == null)
//            {
//                return NotFound();
//            }
//            Contenu objToPatch = _mapper.Map<Contenu>(objFromRepo);
//            patchDoc.ApplyTo(objToPatch, ModelState);
//            if (!TryValidateModel(objToPatch))
//            {
//                return ValidationProblem(ModelState);
//            }
//            _mapper.Map(objToPatch, objFromRepo);
//            _service.UpdateContenu(objFromRepo);
//            return NoContent();
//        }

//        //DELETE api/Contenus/{id}
//        [HttpDelete("{id}")]
//        public ActionResult DeleteContenu(int id)
//        {
//            Contenu obj = _service.GetContenuById(id);
//            if (obj == null)
//            {
//                return NotFound();
//            }
//            _service.DeleteContenu(obj);
//            return NoContent();
//        }


    }
}
