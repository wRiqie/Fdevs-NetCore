using FDevsQuiz.Domain.Interface;
using FDevsQuiz.Domain.Model;
using FDevsQuiz.Domain.Repository;
using System;
using System.Collections.Generic;
using System.Text;

namespace FDevsQuiz.Infra.Data.Repository.Base
{
    public class RespostaRepository: CrudRepository<long, EnqResposta>, IRespostaRepository
    {
        public RespostaRepository(IDbContext context): base(context)
        {

        }
    }
}
