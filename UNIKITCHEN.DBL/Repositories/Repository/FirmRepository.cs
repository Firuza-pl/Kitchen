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
    public class FirmRepository : IRepositoryBase<T_FIRMS>
    {
        Tools tools;
        public FirmRepository()
        {
            tools = new Tools();
        }
        public bool Delete(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<T_FIRMS> GetAll()
        {
            return tools.DB.T_FIRMS.AsNoTracking();
        }

        public T_FIRMS GetById(int id)
        {
            throw new NotImplementedException();
        }

        public int Insert(T_FIRMS entity)
        {
            throw new NotImplementedException();
        }

        public int Update(T_FIRMS entity)
        {
            throw new NotImplementedException();
        }
    }
}
