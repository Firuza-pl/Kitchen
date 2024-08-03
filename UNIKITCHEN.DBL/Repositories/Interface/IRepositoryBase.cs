using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UNIKITCHEN.DBL.Repositories.Interface
{
    public interface IRepositoryBase<T> where T:class
    {
        IEnumerable<T> GetAll();
        T GetById(int id);
        int Update(T entity);
        bool Delete(int id);
        int Insert(T entity);
    }
}
