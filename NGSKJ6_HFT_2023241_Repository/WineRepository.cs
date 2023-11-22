using NGSKJ6_HFT_2023241_Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NGSKJ6_HFT_2023241_Repository
{
    public class WineRepository : Repository<Wine>
    {
        public WineRepository(WineryDbContext ctx) : base(ctx)
        {
        }
        public override Wine Read(int id)
        {
            return ctx.
        }
        public override void Update(Wine entity)
        {
            throw new NotImplementedException();
        }
    }
}
