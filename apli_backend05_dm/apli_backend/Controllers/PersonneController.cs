using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace apli_backend.Controllers  // le CRUD décrit les méthodes create,read,update et delete ci dessous dans un controller
{
    using Services;
    using Models;
    using Services.Impl;

    [Route("api/[Personnes]")]
    [ApiController]

    public class PersonneController : ControllerBase
    {

        private PersonneService service; // il s'agit de l'attribut pour l'injection de dépendances

        public PersonneController (PersonneService service) // il passe en paramètre dans le constructeur pour l'injection
        {
            this.service = service;
        }


        [HttpPost] // la méthode Post permet d'ajouter des informations au serveur 
        [Route("")] // la route est spécifiée ici 
        public Personne Save([FromBody] Personne p)  // public IActionResult Save([FromBody] Personne p)
        {
            return this.service.Save(p); // return Ok(this.service.Save(p));
        }

        [HttpGet] // la méthode Get permet de récupérer des informations sur le serveur
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

        [HttpPut] // la méthode Put petmet de mettre à jour les informations sur le serveur
        [Route("")]
        public Personne Update([FromBody] Personne p)  // public IActionResult Update([FromBody] Personne p)
        {
            return this.service.Modifier(p);  // return Ok(this.service.Modifier(p));
        }

        [HttpDelete] // la méthode Delete permet de supprimer des informations sur le serveur 
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

