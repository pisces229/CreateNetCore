using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using ClassLib.First;
using ClassLib.Second;

namespace Web.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class StartController : ControllerBase
    {
        private readonly ILogger<StartController> _logger;
        public StartController(ILogger<StartController> logger)
        {
            _logger = logger;
        }
        [HttpGet]
        public async Task<IActionResult> Get()
        {
            Console.WriteLine("---------- Test ----------");
            new ClassLibFirst();
            new ClassLibSecond();
            return Ok(await Task.FromResult("Success"));
        }
    }
}
