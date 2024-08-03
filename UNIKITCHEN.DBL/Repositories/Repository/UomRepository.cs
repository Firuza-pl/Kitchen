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
    public class UomRepository : IRepositoryBase<T_UOM>
    {
        Tools tools;
        public UomRepository()
        {
            tools = new Tools();
        }
        public bool Delete(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<T_UOM> GetAll()
        {
            return tools.DB.T_UOM.AsNoTracking().ToList();
        }

        public T_UOM GetById(int id)
        {
            return tools.DB.T_UOM.Find(id);
        }

        public int Insert(T_UOM entity)
        {
            throw new NotImplementedException();
        }

        public int Update(T_UOM entity)
        {
            throw new NotImplementedException();
        }
    }
}
