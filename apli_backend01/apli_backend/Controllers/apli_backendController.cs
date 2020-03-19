using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace apli_backend.Controllers
{
    using DTO

    [Route("api/[controller]")]
    [ApiController]
    public class Apli_backendController : ControllerBase
    {
    }


    [HttpGet]
    public string Get()
    {
        return " God Bless Me ,  please my Lord !";
    }

    [HttpPost]
    public string Post([FromBody] Data content)
    {

    }


 