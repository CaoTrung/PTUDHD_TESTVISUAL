using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Models.Framework;

namespace Models
{
    public class CategoryModel
    {
        OnlineDbcontext context = null;
        public CategoryModel()
        {
            context = new OnlineDbcontext();
        }
        public List<Category> listAll_Category()
        {
            var result = context.Database.SqlQuery<Category>("usp_listcategory").ToList();
            return result;
        }
    }
}
