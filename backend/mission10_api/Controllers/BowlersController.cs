using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
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
        public IEnumerable<object> GetBowlersWithTeams()
        {
            var bowlerData = from Bowlers in _bowlerRepo.Bowlers
                             join Teams in _bowlerRepo.Teams on Bowlers.TeamID equals Teams.TeamID
                             select new JoinedBowler
                             {
                                 BowlerID = Bowlers.BowlerID,
                                 BowlerFirstName = Bowlers.BowlerFirstName,
                                 BowlerMiddleInit = Bowlers.BowlerMiddleInit,
                                 BowlerLastName = Bowlers.BowlerLastName,
                                 BowlerAddress = Bowlers.BowlerAddress,
                                 BowlerCity = Bowlers.BowlerCity,
                                 BowlerState = Bowlers.BowlerState,
                                 BowlerZip = Bowlers.BowlerZip,
                                 BowlerPhoneNumber = Bowlers.BowlerPhoneNumber,
                                 TeamName = Teams.TeamName
                             };
            
            return bowlerData.Where(data => data.TeamName == "Marlins" || data.TeamName == "Sharks").ToList();
        }
    } 
}
