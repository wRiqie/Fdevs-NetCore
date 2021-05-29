using FDevsQuiz.Domain.Interface;
using FDevsQuiz.Domain.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace FDevsQuiz.Domain.Repository
{
    public interface IUsuarioRepository: ICrudRepository<long, AppUsuario>
    {
    }
}
