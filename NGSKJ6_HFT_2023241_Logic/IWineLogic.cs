using NGSKJ6_HFT_2023241_Models;
using System.Linq;

namespace NGSKJ6_HFT_2023241_Logic
{
    public interface IWineLogic
    {
        void Create(Wine item);
        void Delete(int id);
        Wine Read(int id);
        IQueryable<Wine> ReadAll();
        void Update(Wine wine);
    }
}