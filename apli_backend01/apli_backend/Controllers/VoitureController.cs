using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace apli_backend.Controllers
{
    using DTO;
    using Services;
    using Services.Impl;



    [Route("api/[controller]")]
    [ApiController]
    public class VoitureController : ControllerBase
    {

    }
    
    public VoitureController(VoitureService service)
    {
        this.service = service;
    }



    [HttpGet]
    [Route("")]
    public IEnumerable<VoitureDTO> FindAll()
    {
        return this.service.TrouverTout();
    }



    [HttpPost]
    [Route("")]
    public VoitureDTO Save([FromBody] VoitureDTO data)
    {
        return this.service.AjouterUn(data);
    }



    [HttpGet]
    [Route("{id}")]
    public VoitureDTO FindById(int id)
    {
        return this.service.TrouverUn(id);
    }



    [HttpDelete]
    [Route("{id}")]
    public void Delete(int id)
    {
        this.service.Supprimer(id);
    }


    [HttpPut]
    [Route("{id}")]
    public VoitureDTO Update(int id, [FromBody] VoitureDTO data)
    {
        return this.service.Modifier(id, data);
    }


}