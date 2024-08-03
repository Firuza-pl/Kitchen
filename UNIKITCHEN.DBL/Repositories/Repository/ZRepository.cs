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
    public class ZRepository : IRepositoryBase<T_Z>
    {
        Tools tools;
        public ZRepository()
        {
            tools = new Tools();
        }
        public bool Delete(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<T_Z> GetAll()
        {
            throw new NotImplementedException();
        }

        public T_Z GetById(int id)
        {
            throw new NotImplementedException();
        }

        public int Insert(T_Z entity)
        {
            tools.DB.T_Z.Add(entity);

            return tools.DB.SaveChanges();
        }

        public int Update(T_Z entity)
        {
            T_Z Z = tools.DB.T_Z.Find(entity.Z_ID);

            Z.Z_AMOUNT = entity.Z_AMOUNT;

            tools.DB.SaveChanges();

            return Z.Z_ID;
        }

        public int getMaxNo()
        {
            T_Z z = tools.DB.T_Z.OrderByDescending(o=>o.Z_ID).FirstOrDefault();

            if (z!=null)
            {
                return z.Z_ID;
            }
            else
            {
                return 0;
            }
        }
    }
}
