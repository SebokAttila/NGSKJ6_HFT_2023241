using System;
using System.Linq;

namespace NGSKJ6_HFT_2023241_Repository
{
    public interface IRepository <T> where T : class
    {
        IQueryable<T> ReadAll();
        T Read(int id);
        void Create(T entity);
        void Update(T entity);
        void Delete(T entity);

    }
}
