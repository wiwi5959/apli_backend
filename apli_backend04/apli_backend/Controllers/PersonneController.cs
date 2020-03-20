using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace apli_backend.Controllers
{
    using Services;
    using Models;
    using Services.Impl;

    [Route("api/[Personnes]")]
    [ApiController]

    public class PersonneController : ControllerBase
    {

        private PersonneService service; // attribut pour l'injection de dépendances

        public PersonneController (PersonneService service) // paramètre dans le constructeur pour l'injection
        {
            this.service = service;
        }


        [HttpPost]
        [Route("")]
        public Personne Save([FromBody] Personne p)  // public IActionResult Save([FromBody] Personne p)
        {
            return this.service.Save(p); // return Ok(this.service.Save(p));
        }

        [HttpGet]
        [Route("")]
        public IEnumerable<Personne> FindAll()   // public IActionResult FindAll()
        {
            return this.service.TrouverTous();  // return Ok(this.service.TrouverTous());
        }

        [HttpGet]
        [Route("{id}")]
        public Personne FindById(int id)  // public IActionResult FindById(int id)
        {
            return this.service.TrouverUn(id);

            /*    
               try
            {
                return Ok(this.service.TrouverUn(id));
            }
            catch (IndexOutOfRangeException e)
            {
                return NotFound();
            } 
            catch (Exception e)      
            {
                return this.ValidationProblem();
            }
                   
             */
        }

        [HttpPut]
        [Route("")]
        public Personne Update([FromBody] Personne p)  // public IActionResult Update([FromBody] Personne p)
        {
            return this.service.Modifier(p);  // return Ok(this.service.Modifier(p));
        }

        [HttpDelete]
        [Route("{id}")]
        public void Delete(int id)  //   public IActionResult Delete(int id)
        {
            this.service.Supprimer(id);

            /* 
            try
           {
               this.service.Supprimer(id);
               return Ok();
           } catch
           {
               return NotFound();
           }
            */
        }
    }
}

