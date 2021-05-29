using FDevsQuiz.Domain.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace FDevsQuiz.Domain.Model.Base
{
    public interface IPerguntaRepository: ICrudRepository<long, EnqPergunta>
    {
    }
}
