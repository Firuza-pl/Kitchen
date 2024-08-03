using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UNIKITCHEN.DBL.EntityFramework;
using UNIKITCHEN.DBL.Helper;
using UNIKITCHEN.DBL.Repositories.Interface;

namespace UNIKITCHEN.DBL.Repositories.Repository
{
    public class CategoriRepository : IRepositoryBase<T_CATEGORY>
    {
        Tools tools;
        public CategoriRepository()
        {
            tools = new Tools();
        }
        public bool Delete(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<T_CATEGORY> GetAll()
        {
            return tools.DB.T_CATEGORY.AsNoTracking().ToList();
        }

        public T_CATEGORY GetById(int id)
        {
            return tools.DB.T_CATEGORY.Find(id);
        }

        public int Insert(T_CATEGORY entity)
        {
            throw new NotImplementedException();
        }

        public int Update(T_CATEGORY entity)
        {
            throw new NotImplementedException();
        }
    }
}
