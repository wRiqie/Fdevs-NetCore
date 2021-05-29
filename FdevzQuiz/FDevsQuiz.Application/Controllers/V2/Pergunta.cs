using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FDevsQuiz.Application.Controllers.V2
{
    [Controller]
    [Route("v2/Pergunta")]
    public class Pergunta : ControllerBase
    {
        public IActionResult Index()
        {
            return Ok();
        }
    }
}
