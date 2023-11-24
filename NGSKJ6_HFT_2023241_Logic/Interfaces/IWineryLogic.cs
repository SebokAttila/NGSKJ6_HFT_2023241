using NGSKJ6_HFT_2023241_Models;
using System.Linq;

namespace NGSKJ6_HFT_2023241_Logic.Interfaces
{
    public interface IWineryLogic
    {
        void Create(Winery item);
        void Delete(int id);
        Winery Read(int id);
        IQueryable<Winery> ReadAll();
        void Update(Winery wine);
    }
}