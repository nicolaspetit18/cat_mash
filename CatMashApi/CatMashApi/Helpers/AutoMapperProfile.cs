using AutoMapper;
using CatMashApi.Dto;
using CatMashApi.Models;

namespace CatMashApi.Helpers
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()
        {
            //CatScores
            CreateMap<CatScore, CatScoreDto>();
            CreateMap<CatScoreDto, CatScore>();
        }
    }
}
