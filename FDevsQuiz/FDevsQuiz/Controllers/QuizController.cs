using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace FDevsQuiz.Controllers
{
    [Controller]
    [Route("quizzes")]
    public class QuizController : ControllerBase
    {
        [HttpGet]
        public ActionResult<dynamic> Quizzes()
        {
            return Ok(new 
            { 
                CodigoUsuario = 1,
                CodigoQuiz = 1,
                NomeQuiz = "Estrutura Banco de Dados",
                PontuacaoUsuario = 80
            });
        }
    }
}
