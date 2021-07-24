using System;
using System.Collections.Generic;
using System.Linq;
using Jokenpo.API.Data;
using Jokenpo.API.Entities;
using Jokenpo.API.Models;
using Jokenpo.API.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace Jokenpo.API.Repositories
{
    public class RankingRepository : IJokenpoRepository<Ranking>
    {
        private readonly JokenpoContext _context;

        public RankingRepository(JokenpoContext context)
        {
            _context = context;
            _context.ChangeTracker.QueryTrackingBehavior = QueryTrackingBehavior.NoTracking;
        }

        public List<RankingModel> BuscarRanking()
        {
            List<RankingModel> lstRanking=new List<RankingModel>();

            try
            {
                var query =   _context.Rankings
                                    .GroupBy(c => c.Vencedor)
                                    .Select(c => new { Vencedor = c.Key, Total = c.Count()})
                                    .OrderByDescending(c=>c.Total)
                                    .ToList();
                
                foreach(var i in query){
                    lstRanking.Add(new RankingModel(){
                        Vencedor = i.Vencedor,
                        Total = i.Total
                    });
                }

            }
            catch (Exception ex)
            {                
                throw new Exception(ex.Message);
            }
            

            return lstRanking;
        }

        public void Inserir(Ranking entidade)
        {
            _context.Rankings.Add(entidade);
            _context.SaveChanges();
        }

        public List<Ranking> Lista()
        {
            return _context.Rankings.ToList();
            
        }
    }
}