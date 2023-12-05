using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using NGSKJ6_HFT_2023241_Logic.Interfaces;
using NGSKJ6_HFT_2023241_Models;
using System.Collections.Generic;

namespace NGSKJ6_HFT_2023341_Endpoint.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class BarrellController : ControllerBase
    {
        IBarrelLogic logic;

        public BarrellController(IBarrelLogic logic)
        {
            this.logic = logic;
        }


        [HttpGet]
        public IEnumerable<Barrell> ReadAll()
        {
            return this.logic.ReadAll();
        }

        [HttpGet("{id}")]
        public Barrell Read(int id)
        {
            return this.logic.Read(id);
        }

        [HttpPost]
        public void Create([FromBody] Barrell value)
        {
            this.logic.Create(value);
        }

        [HttpPut]
        public void Put([FromBody] Barrell value)
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
