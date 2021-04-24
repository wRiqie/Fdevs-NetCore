using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace FDevsQuiz.Controllers
{
    [Controller]
    [Route("dificuldades")]
    public class DificuldadesController : ControllerBase
    {
        [HttpGet]
        public ActionResult<dynamic> Dificuldades()
        {
            return Ok(new 
            { 
                CodigoDificuldade = 1,
                Nome = "Facil",
                QuantidadeDeQuizzes = 1
            });
        }
    }
}
