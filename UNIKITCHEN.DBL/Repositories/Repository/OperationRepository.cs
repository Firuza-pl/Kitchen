using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UNIKITCHEN.DBL.EntityFramework;
using UNIKITCHEN.DBL.Helper;
using UNIKITCHEN.DBL.Repositories.Interface;

namespace UNIKITCHEN.DBL.Repositories.Repository
{
    public class OperationRepository : IRepositoryBase<T_OPERATION>
    {
        Tools tools;
        public OperationRepository()
        {
            tools = new Tools();
        }
        public bool Delete(int id)
        {
            T_OPERATION operation = tools.DB.T_OPERATION.Find(id);
            operation.OPR_STATUS = -1;
            return tools.DB.SaveChanges() >0 ? true:false;
        }

        public IEnumerable<T_OPERATION> GetAll()
        {
            return tools.DB.T_OPERATION.AsNoTracking().ToList();
        }

        public List<SP_GETOPERATIONS_Result> GetOperations()
        {
            var list = tools.DB.SP_GETOPERATIONS().ToList();

            return list;
        }
        public T_OPERATION GetById(int oprID)
        {
            T_OPERATION operation =  tools.DB.T_OPERATION.Find(oprID);

            return operation;
        }

        public int Insert(T_OPERATION entity)
        {
            tools.DB.T_OPERATION.Add(entity);

             tools.DB.SaveChanges();

            return entity.OPR_ID;
        }

        public int InsertLine(T_OPERATIONLINE entity)
        {
            tools.DB.T_OPERATIONLINE.Add(entity);
            return tools.DB.SaveChanges();
        }

        public int Update(T_OPERATION entity)
        {
            T_OPERATION operation = tools.DB.T_OPERATION.Find(entity.OPR_ID);
            operation.OPR_TYPE = entity.OPR_TYPE;
            operation.OPR_STYPE = entity.OPR_STYPE;
            operation.OPR_F_ID = entity.OPR_F_ID;
            operation.OPR_E_ID = entity.OPR_E_ID;
            operation.OPR_BL = entity.OPR_BL;
            operation.OPR_TOTAL = entity.OPR_TOTAL;
            operation.OPR_Z_ID = entity.OPR_Z_ID;

            tools.DB.Entry(operation).State = EntityState.Modified;

            int result = tools.DB.SaveChanges();
            return operation.OPR_ID;

           
        }

        public IEnumerable<SP_GETMENUS_Result> GetMenusByCat(int CAT_ID)
        {
            var menus = tools.DB.SP_GETMENUS(CAT_ID).ToList();
            return menus;

        }

        public IEnumerable<SP_GETMENUSDAILY_Result> GetMenusDaily(int CAT_ID)
        {
            var menus = tools.DB.SP_GETMENUSDAILY(CAT_ID).ToList();
            return menus;
        }

        public int getMaxID()
        {
            if (tools.DB.T_OPERATION.ToList().Count == 0)
            {
                return 1;
            }
            else
            {
                return tools.DB.T_OPERATION.Max(o => o.OPR_ID);
            }
           
         
        }

        public List<T_OPERATIONLINE> getByIdForLine(int oprID)
        {
            var list  = tools.DB.T_OPERATIONLINE.Where(w => w.ORRL_OPR_ID == oprID).ToList();
            return list;
        }

        public bool DeleteLine(int id)
        {
            IEnumerable<T_OPERATIONLINE> operationLine = tools.DB.T_OPERATIONLINE.Where(w => w.ORRL_OPR_ID == id);

            
            tools.DB.T_OPERATIONLINE.RemoveRange(operationLine);

            int result =tools.DB.SaveChanges();

            return result > 0 ? true : false;
        }
       
        public List<SP_GETOPERATIONOFTHEDAYE_Result> getOperationsOfTheDay()
        {
            var list = tools.DB.SP_GETOPERATIONOFTHEDAYE().ToList();
            return list;
        }
    }
}
