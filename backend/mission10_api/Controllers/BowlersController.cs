using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using mission10_api.Models;

namespace mission10_api.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class BowlersController : ControllerBase
    {
        private IBowlingRepository _bowlerRepo;
        
        public BowlersController(IBowlingRepository temp) 
        {
            _bowlerRepo = temp;
        }

        [HttpGet]
        public IEnumerable<Bowler> Get()
        {
            var bowlerData = _bowlerRepo.Bowlers.ToArray();
            
            return bowlerData;
        }
    } 
}
