using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Core.Interfaces
{
    public interface ICollectionContext<T>
    {
        IEnumerable<T> GetAll();
        T Get(string username);
        bool Create(T user);
        bool Delete(string username);
        bool Delete(MongoDB.Bson.ObjectId id);
        bool Update(T user);
    }
}
