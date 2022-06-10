using System;
using System.Collections.Generic;
using System.Text;

namespace booking.Database.Repository
{
    public interface IRepositoryBase<T>
    {
        IList<T> GetAll(bool asNoTracking = false, bool includeDeleted = false);
        T GetById(int id, bool asNoTracking = false);
        void Insert(T record);
        void Update(T record);
        void Delete(T record);
    }
}
