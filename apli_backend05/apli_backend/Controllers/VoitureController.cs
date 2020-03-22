using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace apli_backend.Controllers
{
    using Models;
    using Services;
    using Services.Impl;

    [Route("api/[Voitures]")]
    [ApiController]

    public class VoitureController : ControllerBase
    {

        private VoitureService service; // attribut pour l'injection de dépendances

        public VoitureController(VoitureService service) // paramètre dans le constructeur pour l'injection
        {
            this.service = service;
        }

        [HttpPost]
        [Route("")]
        public Voiture Save([FromBody] Voiture p)
        {
            return this.service.Save(p);
        }

        [HttpGet]
        [Route("")]
        public IEnumerable<Voiture> FindAll()
        {
            return this.service.TrouverTous();
        }

        [HttpGet]
        [Route("{id}")]
        public Voiture FindById(int id)
        {
            return this.service.TrouverUn(id);
        }

        [HttpPut]
        [Route("")]
        public Voiture Update([FromBody] Voiture v)
        {
            return this.service.Modifier(v);
        }

        [HttpDelete]
        [Route("{id}")]
        public void Delete(int id)
        {
            this.service.Supprimer(id);
        }
    }
}

