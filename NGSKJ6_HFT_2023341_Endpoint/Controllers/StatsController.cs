using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using NGSKJ6_HFT_2023241_Logic.Interfaces;
using NGSKJ6_HFT_2023241_Models;
using System.Linq;

namespace NGSKJ6_HFT_2023341_Endpoint.Controllers
{
    [Route("[controller]/[action]")]
    public class StatsController : ControllerBase
    {
        IWineryLogic logic;

        public StatsController(IWineryLogic logic)
        {
            this.logic = logic;
        }
        
        [HttpGet]
        public IQueryable<Wine> ListByVintage(int vintage)
        {
            return logic.ListByVintage(vintage);
        }

        [HttpGet]
        public IQueryable<Barrell> BarrelsByMaterial(string material)
        {
            return logic.BarrellsByMaterial(material);
        }

        [HttpGet]
        public Wine BiggestBatch([FromQuery] string name)
        {
            return (Wine)logic.BiggestBatch(name);
        }

        [HttpGet]
        public IQueryable<Wine> WinesByWinery([FromQuery] string winery)
        {
            return logic.WinesByWinery(winery);
        }

        [HttpGet]
        public Barrell BiggestBarrelInWinery([FromQuery] string winery)
        {
            return logic.BiggestBarrelInWinery(winery);
        }
    }
}
