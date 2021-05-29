using FDevsQuiz.Domain.Interface;
using FDevsQuiz.Domain.Model;
using FDevsQuiz.Domain.Model.Base;
using System;
using System.Collections.Generic;
using System.Text;

namespace FDevsQuiz.Infra.Data.Repository.Base
{
    public class PerguntaRepository: CrudRepository<long, EnqPergunta>, IPerguntaRepository 
    {
        public PerguntaRepository(IDbContext context): base(context)
        {

        }
    }
}
