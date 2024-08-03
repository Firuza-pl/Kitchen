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
    public class MealPriceRepository : IRepositoryBase<T_MEALPRICE>
    {
        Tools tools;
        public MealPriceRepository()
        {
            tools = new Tools();
        }
        public bool Delete(int id)
        {
            T_MEALPRICE mealPrice = tools.DB.T_MEALPRICE.Find(id);

            mealPrice.MP_STATUS = 1;
          
            return tools.DB.SaveChanges()>0 ? true:false;
        }

        public IEnumerable<T_MEALPRICE> GetAll()
        {
            return tools.DB.T_MEALPRICE.AsNoTracking().Where(w=>w.MP_STATUS==0).ToList();
        }

        public T_MEALPRICE GetMealPrice(int M_ID)
        {
            return tools.DB.T_MEALPRICE.Where(w=>w.MP_BGDATE <= DateTime.Now &&  DateTime.Now <= w.MP_ENDATE && w.MP_M_ID== M_ID).FirstOrDefault();
        }

        public T_MEALPRICE GetById(int id)
        {
            return tools.DB.T_MEALPRICE.Find(id);
        }

        public int Insert(T_MEALPRICE entity)
        {
            tools.DB.T_MEALPRICE.Add(entity);
            tools.DB.SaveChanges();

            return entity.MP_ID;

        }

        public int Update(T_MEALPRICE entity)
        {
            T_MEALPRICE mealPrice = tools.DB.T_MEALPRICE.Find(entity.MP_ID);

            mealPrice.MP_M_ID = entity.MP_M_ID;
            mealPrice.MP_BGDATE = entity.MP_BGDATE;
            mealPrice.MP_ENDATE = entity.MP_ENDATE;
            mealPrice.MP_AMOUNT = entity.MP_AMOUNT;

            tools.DB.SaveChanges();

            return mealPrice.MP_ID;
        }
    }
}
