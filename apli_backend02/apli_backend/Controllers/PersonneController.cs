using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace apli_backend.Controllers
{
    
    using Models;
    using Services.Impl;

    [Route("api/[Personnes]")]
    [ApiController]

    public class PersonneController : ControllerBase
    {

        private PersonneService service; // attribut pour l'injection de dépendances

        public PersonneController (PersonneService service) // paramètre dans le constructeur pour l'injection
        {
            this.services = service;
        }

        [HttpPost]
        [Route("")]
        public Personne Save([FromBody] Personne p)
        {
            return this.service.Save(p);
        }

        [HttpGet]
        [Route("")]
        public IEnumerable<Personne> FindAll()
        {
            return this.service.TrouverTous();
        }

        [HttpGet]
        [Route("{id}")]
        public Personne FindById(int id)
        {
            return this.service.TrouverUn(id);
        }

        [HttpPut]
        [Route("")]
        public Personne Update([FromBody] Personne p)
        {
            return this.service.Modifier(p);
        }

        [HttpDelete]
        [Route("{id}")]
        public void Delete(int id)
        {
            this.service.Supprimer(id);
        }
    }
}

