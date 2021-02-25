using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using PetHero.Service.Service;

namespace PetHero.Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class PetController : ControllerBase
    {
        [HttpGet]
        public List<string> Names()
        {
            var service = new PetService();

            return service.PetsNames();
        }
    }
}