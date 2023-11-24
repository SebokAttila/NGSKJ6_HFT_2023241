using NGSKJ6_HFT_2023241_Models;
using System.Linq;

namespace NGSKJ6_HFT_2023241_Logic.Interfaces
{
    public interface IBarrelLogic
    {
        void Create(Barrell item);
        void Delete(int id);
        Barrell Read(int id);
        IQueryable<Barrell> ReadAll();
        void Update(Barrell barrell);
    }
}