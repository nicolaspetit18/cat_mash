using System.Collections.Generic;
using AutoMapper;
using CatMashApi.Dto;
using CatMashApi.Interfaces;
using CatMashApi.Models;
using Microsoft.AspNetCore.Mvc;

namespace CatMashApi.Controllers
{
    [Route("api/[controller]")]
    public class CatScoresController : Controller
    {
        private ICatScoreService _catScoreService;
        private IMapper _mapper;

        public CatScoresController(
            ICatScoreService catScoreService,
            IMapper mapper)
        {
            _catScoreService = catScoreService;
            _mapper = mapper;
        }

        // GET api/catscores
        [HttpGet("GetTop")]
        public IEnumerable<CatScoreDto> GetTop(int topMaxNumber)
        {
            var catScore = _catScoreService.GetTopScore(topMaxNumber);
            return _mapper.Map<IEnumerable<CatScoreDto>>(catScore);
        }

        // GET api/catscores/5
        [HttpGet]
        public CatScoreDto Get(string id)
        {
            var catScore = _catScoreService.Get(id);
            return _mapper.Map<CatScoreDto>(catScore);
        }

        // POST api/catscores
        [HttpPost]
        public void Post([FromBody]CatScoreDto catScoreDto)
        {
            var catScore = _mapper.Map<CatScore>(catScoreDto);
            _catScoreService.Add(catScore);
        }
    }
}
