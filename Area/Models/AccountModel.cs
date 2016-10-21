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
        private LoginDbContext context = null;
        public AccountModel()
        {
            context = new LoginDbContext();
        }

        public bool Login(string userName, string password)
        {
            object[] sqlParams = 
            {
                new SqlParameter("@UserName", userName),
                new SqlParameter("@Password", password),
            };
            var res = context.Database.SqlQuery<bool>("Sp_account_login @UserName, @Password", sqlParams).SingleOrDefault();
            return res;
        }
    }
}
