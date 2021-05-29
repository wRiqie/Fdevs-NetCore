using FDevsQuiz.Domain.Repository;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FDevsQuiz.Application.Controllers.V2
{
    [Controller]
    [Route("v2/Alternativa")]
    public class AlternativaController : ControllerBase
    {
        private readonly IAlternativaRepository _alternativaRepository;
        public IActionResult Index()
        {
            return Ok();
        }
    }
}
