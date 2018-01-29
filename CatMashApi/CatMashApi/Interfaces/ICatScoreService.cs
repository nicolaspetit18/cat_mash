using CatMashApi.Models;
using System.Collections.Generic;

namespace CatMashApi.Interfaces
{
    public interface ICatScoreService
    {
        CatScore Get(string id);

        CatScore Add(CatScore catScore);

        CatScore IncreaseScore(string id);

        CatScore DecreaseScore(string id);

        IEnumerable<CatScore> GetTopScore(int topMax);
    }
}
