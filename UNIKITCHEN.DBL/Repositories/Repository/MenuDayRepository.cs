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
    public class MenuDayRepository : IRepositoryBase<T_MENUDAY>
    {
        Tools tools;
        public MenuDayRepository()
        {
            tools = new Tools();
        }
        public bool Delete(int id)
        {
            T_MENUDAY menuDay = tools.DB.T_MENUDAY.Find(id);
            menuDay.MD_STATUS = -1;

            return tools.DB.SaveChanges() > 0 ? true:false;
        }

        public IEnumerable<T_MENUDAY> GetAll()
        {
            return tools.DB.T_MENUDAY.AsNoTracking().Where(w=>w.MD_STATUS==0);
        }

        public T_MENUDAY GetById(int id)
        {
            return tools.DB.T_MENUDAY.Find(id);
        }

        public int Insert(T_MENUDAY entity)
        {
            tools.DB.T_MENUDAY.Add(entity);
            tools.DB.SaveChanges();

            return entity.MD_ID;
        }

        public int Update(T_MENUDAY entity)
        {
            T_MENUDAY menuDay = tools.DB.T_MENUDAY.Find(entity.MD_ID);

            menuDay.MD_BLBGTIME = entity.MD_BLBGTIME;
            menuDay.MD_BLENTIME = entity.MD_BLENTIME;
            menuDay.MD_DATE = entity.MD_DATE;
            menuDay.MD_U_ID = entity.MD_U_ID;
            menuDay.MD_STATUS = entity.MD_STATUS;

            tools.DB.SaveChanges();

            return menuDay.MD_ID;
        }

        public int InsertLine(List<T_MENUDAYLINE> entity)
        {
            tools.DB.T_MENUDAYLINE.AddRange(entity);

            return tools.DB.SaveChanges();
        }

        public List<T_MENUDAYLINE> getLineById(int id)
        {
            return tools.DB.T_MENUDAYLINE.Where(w => w.MDL_MD_ID == id).ToList();
        }
        public bool DeleteLine(int id)
        {
            List<T_MENUDAYLINE> lines = tools.DB.T_MENUDAYLINE.Where(w => w.MDL_MD_ID == id).ToList();

            tools.DB.T_MENUDAYLINE.RemoveRange(lines);

            return tools.DB.SaveChanges() > 0 ? true:false ;
        }

    }
}
