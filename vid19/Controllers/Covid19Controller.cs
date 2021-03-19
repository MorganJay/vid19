using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using vid19.Models;
using vid19.Services;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace vid19.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class Covid19Controller : ControllerBase
    {
        private readonly Covid19Services _covid19Service;

        public Covid19Controller(Covid19Services covid19Services)
        {
            _covid19Service = covid19Services;
        }

        // GET: api/<Covid19Controller>
        [HttpGet]
        public async Task<ActionResult<Stats>> World()
        {
            return await _covid19Service.GetWorldStats();
        }
    }
}