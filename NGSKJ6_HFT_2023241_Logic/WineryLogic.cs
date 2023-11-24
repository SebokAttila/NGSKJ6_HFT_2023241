using NGSKJ6_HFT_2023241_Models;
using NGSKJ6_HFT_2023241_Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NGSKJ6_HFT_2023241_Logic
{
    public class WineryLogic : IWineryLogic
    {
        IRepository<Winery> repository;

        public WineryLogic(IRepository<Winery> repository)
        {
            this.repository = repository;
        }
        public void Create(Winery item)
        {
            if (item.Name.Length < 0 || item.Name.Length > 99) throw new FormatException();

            if (item.Location == null || item.Location == "")
            {
                throw new Exception();
            }
            this.repository.Create(item);
        }
        public void Delete(int id)
        {
            if (!repository.ReadAll().Select(p => p.WineryId).Contains(id))
            {
                throw new FormatException();
            }
            this.repository.Delete(id);
        }
        public Winery Read(int id)
        {
            return this.repository.Read(id);
        }
        public IQueryable<Winery> ReadAll()
        {
            return this.repository.ReadAll();
        }
        public void Update(Winery wine)
        {
            this.repository.Update(wine);
        }
    }
}
