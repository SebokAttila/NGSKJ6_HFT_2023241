using NGSKJ6_HFT_2023241_Models;
using System.Linq;
using System.Security.Cryptography.X509Certificates;

namespace NGSKJ6_HFT_2023241_Logic.Interfaces
{
    public interface IWineryLogic
    {
        void Create(Winery item);
        void Delete(int id);
        Winery Read(int id);
        IQueryable<Winery> ReadAll();
        void Update(Winery wine);
        public IQueryable<Wine> ListByVintage(int vintage);
        public IQueryable<Barrell> BarrellsByMaterial(string material);
        public IQueryable<Wine> BiggestBatch(string name);
        public IQueryable<Wine> WinesByWinery(string winery);
        public Barrell BiggestBarrelInWinery(string winery);


    }
}