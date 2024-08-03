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
    public class MealRepository : IRepositoryBase<T_MEALS>
    {
        Tools tools;
        public MealRepository()
        {
            tools = new Tools();
        }
        public bool Delete(int id)
        {
            T_MEALS meals = tools.DB.T_MEALS.Find(id);
            meals.M_STATUS = -1;

            return tools.DB.SaveChanges()>0 ? true:false;

        }

        public IEnumerable<T_MEALS> GetAll()
        {
            var list = tools.DB.T_MEALS.AsNoTracking().ToList();
            return list;
        }

        public IEnumerable<T_MEALS> SearchMeal(string searchMeal)
        {
            return tools.DB.T_MEALS.Where(W => W.M_NAME.ToLower().StartsWith(searchMeal.ToLower()));
        }

        public T_MEALS GetById(int id)
        {
            T_MEALS meals = tools.DB.T_MEALS.FirstOrDefault(f => f.M_ID == id);

            return meals;
        }

        public int Insert(T_MEALS entity)
        {
            tools.DB.T_MEALS.Add(entity);
            tools.DB.SaveChanges();

            return entity.M_ID;
        }

        public int Update(T_MEALS entity)
        {
            T_MEALS meals = tools.DB.T_MEALS.Find(entity.M_ID);
            
            meals.M_CODE = entity.M_CODE;
            meals.M_NAME = entity.M_NAME;
            meals.M_CAT_ID = entity.M_CAT_ID;
            meals.M_OU_ID = entity.M_OU_ID;
            meals.M_COFISENT = entity.M_COFISENT;
          
            tools.DB.SaveChanges();

            return meals.M_ID;
        }
    }
}
