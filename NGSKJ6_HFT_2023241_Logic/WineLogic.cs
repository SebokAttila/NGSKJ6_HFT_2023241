﻿using NGSKJ6_HFT_2023241_Logic.Interfaces;
using NGSKJ6_HFT_2023241_Models;
using NGSKJ6_HFT_2023241_Repository;
using System;
using System.Linq;

namespace NGSKJ6_HFT_2023241_Logic
{
    public class WineLogic : IWineLogic
    {
        IRepository<Wine> repository;

        public WineLogic(IRepository<Wine> repository)
        {
            this.repository = repository;
        }

        public void Create(Wine item)
        {
            

            if (item.Amount <= 0)
            {
                throw new Exception();
            }
            this.repository.Create(item);
        }
        public void Delete(int id)
        {
            if (!repository.ReadAll().Select(p => p.WineId).Contains(id))
            {
                throw new FormatException();
            }
            this.repository.Delete(id);
        }

        public Wine Read(int id)
        {
            return this.repository.Read(id);
        }
        public IQueryable<Wine> ReadAll()
        {
            return this.repository.ReadAll();
        }
        public void Update(Wine wine)
        {
            this.repository.Update(wine);
        }
    }
}
