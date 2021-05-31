using FDevsQuiz.Domain.Interface;
using FDevsQuiz.Domain.Model;
using FDevsQuiz.Domain.Repository;
using System;
using System.Collections.Generic;
using System.Text;

namespace FDevsQuiz.Infra.Data.Repository.Base
{
    public class UsuarioRepository: CrudRepository<long, AppUsuario>, IUsuarioRepository
    {
        public UsuarioRepository(IDbContext context): base(context)
        {
        }
    }
}
