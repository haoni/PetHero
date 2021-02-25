using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using PetHero.Service.Service;
using PetHero.Service.Dto;

namespace PetHero.Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class OwnerController : ControllerBase
    {
        [HttpGet]
        public List<OwnerDto> Buscar()
        {
            var service = new OwnerService();

            return service.GetOwners();
        }
    }
}