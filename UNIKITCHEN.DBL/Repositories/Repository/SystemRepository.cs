using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UNIKITCHEN.DBL.Entity;
using UNIKITCHEN.DBL.EntityFramework;
using UNIKITCHEN.DBL.Helper;

namespace UNIKITCHEN.DBL.Repositories.Repository
{
    public class SystemRepository
    {
        Tools tools;
      
        public SystemRepository()
        {
            tools = new Tools();
        }

        public T_SYS_USER Login(UserLoginModel user)
        {
            try
            {
             
                if (!string.IsNullOrEmpty(user.USERNAME) && !string.IsNullOrEmpty(user.PASSWORD))
                {

                    var userHashedPassword = tools.GenerateSHA256String(user.PASSWORD.Trim());

                    // var list = tools.DB.T_SYS_USER.ToList();

                    var checkUser = tools.DB.T_SYS_USER.ToList().FirstOrDefault(
                    x => x.U_USERNAME.ToLower().Trim() == user.USERNAME.ToLower().Trim() &&
                    x.U_PASSWORD == userHashedPassword);



                    //var checkUser = tools.DB.T_SYS_USER.ToList().FirstOrDefault(
                    //x => x.U_USERNAME.ToLower().Trim() == user.USERNAME.ToLower().Trim() &&
                    //x.U_PASSWORD == userHashedPassword);



                    if (checkUser != null)
                    {
                        return checkUser;

                    }
                    else
                        return null;
                }

                else
                    return null;

            }
            catch (Exception ex)
            {
                return null;
            }


        }
    }
}
