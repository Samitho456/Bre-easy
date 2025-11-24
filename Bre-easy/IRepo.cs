using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bre_easy
{
    public interface IRepo<T>
    {
        void Add(T obj);
        IEnumerable<T> GetAll();
        T GetById(int id);
        T Remove(int id);
        T GetByLocation(int id);
        T Update(int id, T obj);

    }
}
