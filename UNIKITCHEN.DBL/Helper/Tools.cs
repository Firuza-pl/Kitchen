using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using UNIKITCHEN.DBL.EntityFramework;

namespace UNIKITCHEN.DBL.Helper
{
    public class Tools
    {
        private DB_UNIKITCHENEntities db;

            //private readonly string constr = @"metadata=res://*/EntityFramework.DB_UNIKITCHENModel.csdl|res://*/EntityFramework.DB_UNIKITCHENModel.ssdl|res://*/EntityFramework.DB_UNIKITCHENModel.msl;provider=System.Data.SqlClient;provider connection string='data source=192.168.37.223;initial catalog=DB_UNIKITCHEN;user id=sa;password=Hp2014;MultipleActiveResultSets=True;App=EntityFramework'";

       private readonly string constr = @"metadata=res://*/EntityFramework.DB_UNIKITCHEN.csdl|res://*/EntityFramework.DB_UNIKITCHEN.ssdl|res://*/EntityFramework.DB_UNIKITCHEN.msl;provider=System.Data.SqlClient;provider connection string='data source=.;initial catalog=DB_UNIKITCHEN;integrated security=True;MultipleActiveResultSets=True;App=EntityFramework'";
        public DB_UNIKITCHENEntities DB
        {
            get
            {
                if (db == null)
                    db = new DB_UNIKITCHENEntities(constr);
                return db;
            }
        }

        public string GenerateSHA256String(string inputString)
        {
            SHA256 sha256 = SHA256Managed.Create();
            byte[] bytes = Encoding.UTF8.GetBytes(inputString);
            byte[] hash = sha256.ComputeHash(bytes);
            return GetStringFromHash(hash);
        }
        private string GetStringFromHash(byte[] hash)
        {
            StringBuilder result = new StringBuilder();
            for (int i = 0; i < hash.Length; i++)
            {
                result.Append(hash[i].ToString("X2"));
            }
            return result.ToString();
        }



    }
}
