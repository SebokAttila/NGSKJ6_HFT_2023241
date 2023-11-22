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
            return ctx.Barrels.FirstOrDefault(p => p.BarrelId == id);
        }

        public override void Update(Barrell entity)
        {
            var old = Read(entity.BarrelId);
            foreach (var item in entity.GetType().GetProperties())
            {
                item.SetValue(old, item.GetValue(entity));
            }
            ctx.SaveChanges();
        }
    }
}
