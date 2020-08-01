using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using SimplyPlan.Infrastructure.DataModels;

namespace SimplyPlan.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProjectController : ControllerBase
    {


        [HttpGet]
        public IActionResult GetAll()
        {
            return Ok();
        }

        [HttpPost]
        [Route("AddProject")]
        public IActionResult AddProject([FromBody]ProjectSubmitModel model)
        {
            return Ok();

        }
    }
}
