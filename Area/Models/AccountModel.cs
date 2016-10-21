using Models.Framework;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;

namespace Models
{
    public class AccountModel
    {
        private OnlineDbcontext context = null;
        public AccountModel()
        {
            context = new OnlineDbcontext();
        }

        public bool Login(string userName, string password)
        {
            object[] sqlParams = 
            {
                new SqlParameter("@UserName", userName),
                new SqlParameter("@Password", password),
            };
            var res = context.Database.SqlQuery<int>("usp_login @UserName, @Password", sqlParams).SingleOrDefault();
            return Convert.ToBoolean(res);
        }
    }
}
