using System.Collections.Generic;
using Jokenpo.API.Entities;
using Jokenpo.API.Models;

namespace Jokenpo.API.Repositories.Interfaces
{
    public interface IJokenpoRepository<T>
    {
         void Inserir(T entidade);
         List<RankingModel> BuscarRanking();
         List<T> Lista();
    }
}