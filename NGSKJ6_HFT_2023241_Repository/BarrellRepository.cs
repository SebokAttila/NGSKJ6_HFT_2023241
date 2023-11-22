using NGSKJ6_HFT_2023241_Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NGSKJ6_HFT_2023241_Repository
{
    public class BarrellRepository : Repository<Barrell>
    {
        public BarrellRepository(WineryDbContext ctx) : base(ctx)
        {
        }

        public override Barrell Read(int id)
        {
            throw new NotImplementedException();
        }

        public override void Update(Barrell entity)
        {
            throw new NotImplementedException();
        }
    }
}
