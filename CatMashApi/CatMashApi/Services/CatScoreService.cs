using CatMashApi.Dto;
using CatMashApi.Helpers;
using CatMashApi.Interfaces;
using CatMashApi.Models;
using System.Collections.Generic;
using System.Linq;

namespace CatMashApi.Services
{
    public class CatScoreService : ICatScoreService
    {
        private CatScoreContext _context;

        public CatScoreService(CatScoreContext context)
        {
            _context = context;
        }

        public CatScore Add(CatScore catScore)
        {
            _context.Add(catScore);
            _context.SaveChanges();

            return catScore;
        }

        public CatScore DecreaseScore(string id)
        {
            var catScore = _context.CatScores.Find(id);
            if(catScore == null)
            {
                throw new System.Exception();
            }

            catScore.Score--;

            _context.Update(catScore);
            _context.SaveChanges();

            return catScore;
        }

        public CatScore Get(string id)
        {
            var catScore = _context.CatScores.Find(id);
            if (catScore == null)
            {
                throw new System.Exception();
            }
            return catScore;
        }

        public IEnumerable<CatScore> GetTopScore(int topMax)
        {
            return _context.CatScores.OrderByDescending(cs => cs.Score).Take(topMax);
        }

        public CatScore IncreaseScore(string id)
        {
            var catScore = _context.CatScores.Find(id);
            if (catScore == null)
            {
                throw new System.Exception();
            }

            catScore.Score++;

            _context.Update(catScore);
            _context.SaveChanges();

            return catScore;
        }
    }
}
