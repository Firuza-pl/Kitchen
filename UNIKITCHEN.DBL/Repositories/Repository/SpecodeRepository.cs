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
    public class SpecodeRepository : IRepositoryBase<T_SPECODE>
    {
        Tools tools;
        public SpecodeRepository()
        {
            tools = new Tools();
        }
        public bool Delete(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<T_SPECODE> GetAll()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<T_SPECODE> GetAllByType(string SC_TYPE)
        {
            return tools.DB.T_SPECODE.Where(s => s.SC_TYPE == SC_TYPE);
        }
        public T_SPECODE GetById(int id)
        {
            throw new NotImplementedException();
        }

        public int Insert(T_SPECODE entity)
        {
            throw new NotImplementedException();
        }

        public int Update(T_SPECODE entity)
        {
            throw new NotImplementedException();
        }
    }
}
