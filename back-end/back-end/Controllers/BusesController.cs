using back_end.Entidades;
using back_end.Filtros;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace back_end.Controllers
{
    [Route("api/buses")]
    [ApiController]
    //[Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme)]
    public class BusesController: ControllerBase
    {
        private readonly ILogger<BusesController> logger;

        public BusesController(
            ILogger<BusesController>logger)
        {
            this.logger = logger;
        }

        [HttpGet] // api/buses      
        public ActionResult<List<Buses>> Get()
        {
            return new List<Buses>() { new Buses() { Id = 1, tipoBus = "Leito" } };
        }        

        [HttpGet("{Id:int}")]
        public async Task<ActionResult<Buses>> Get(int Id)
        {
            throw new NotImplementedException();
        }

        [HttpPost]
        public ActionResult Post([FromBody] Buses buses)
        {
            throw new NotImplementedException();
        }
        
        [HttpPut]
        public ActionResult Put([FromBody] Buses buses)
        {
            throw new NotImplementedException();
        }
        
        [HttpDelete]
        public ActionResult Delete()
        {
            throw new NotImplementedException();
        }
    }
}
