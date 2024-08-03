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
    public class EmployeeRepository : IRepositoryBase<T_EMPLOYEE>
    {
        Tools tools;
        public EmployeeRepository()
        {
            tools = new Tools();
        }
        public bool Delete(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<T_EMPLOYEE> GetAll()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<T_EMPLOYEE> GetEmployeeByFirm(int FRM_ID)
        {
            return tools.DB.T_EMPLOYEE.Where(w => w.E_F_ID == FRM_ID);
        }
        public T_EMPLOYEE GetById(int id)
        {
            throw new NotImplementedException();
        }

        public int Insert(T_EMPLOYEE entity)
        {
            throw new NotImplementedException();
        }

        public int Update(T_EMPLOYEE entity)
        {
            throw new NotImplementedException();
        }
    }
}
