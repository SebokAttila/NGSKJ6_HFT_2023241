using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using NGSKJ6_HFT_2023241_Logic;
using NGSKJ6_HFT_2023241_Logic.Interfaces;
using NGSKJ6_HFT_2023241_Models;
using System.Collections.Generic;

namespace NGSKJ6_HFT_2023341_Endpoint.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class WineryController : ControllerBase
    {
        IWineryLogic logic;

        public WineryController(IWineryLogic logic)
        {
            this.logic = logic;
        }


        [HttpGet]
        public IEnumerable<Winery> ReadAll()
        {
            return this.logic.ReadAll();
        }

        [HttpGet("{id}")]
        public Winery Read(int id)
        {
            return this.logic.Read(id);
        }

        [HttpPost]
        public void Create([FromBody] Winery value)
        {
            this.logic.Create(value);
        }

        [HttpPut]
        public void Put([FromBody] Winery value)
        {
            this.logic.Update(value);
        }

        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            this.logic.Delete(id);
        }
    }
}
