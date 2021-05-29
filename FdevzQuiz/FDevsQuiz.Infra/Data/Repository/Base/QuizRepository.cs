using FDevsQuiz.Domain.Interface;
using FDevsQuiz.Domain.Model;
using FDevsQuiz.Domain.Repository;
using System;
using System.Collections.Generic;
using System.Text;

namespace FDevsQuiz.Infra.Data.Repository.Base
{
    public class QuizRepository: CrudRepository<long, EnqQuiz>, IQuizRepository
    {
        public QuizRepository(IDbContext context): base(context)
        {

        }
    }
}
