using NGSKJ6_HFT_2023241_Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NGSKJ6_HFT_2023241_Repository
{
    public class WineryRepository : Repository<Winery>
    {
        public WineryRepository(WineryDbContext ctx) : base(ctx)
        {
        }
        public override Winery Read(int id)
        {
            throw new NotImplementedException();
        }
        public override void Update(Winery entity)
        {
            throw new NotImplementedException();
        }
    }
}
