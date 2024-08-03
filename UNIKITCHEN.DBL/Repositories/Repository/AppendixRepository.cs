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
    public class AppendixRepository : IRepositoryBase<T_APPENDIX>
    {
        Tools tools;
        public AppendixRepository()
        {
            tools = new Tools();
        }
        public bool Delete(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<T_APPENDIX> GetAll()
        {
            throw new NotImplementedException();
        }

        public T_APPENDIX GetById(int id)
        {
            throw new NotImplementedException();
        }

        public int Insert(T_APPENDIX entity)
        {
            throw new NotImplementedException();
        }

        public int Update(T_APPENDIX entity)
        {
            throw new NotImplementedException();
        }

        public T_APPENDIX GetBisnessLunch(int F_ID)
        {
            T_APPENDIX appendix = tools.DB.T_APPENDIX.FirstOrDefault(w => w.A_F_ID == F_ID && w.A_BGDATE <= DateTime.Now && w.A_ENDATE >= DateTime.Now);
            return appendix;
        }
    }
}
