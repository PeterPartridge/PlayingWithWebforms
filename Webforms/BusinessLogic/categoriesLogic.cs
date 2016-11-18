using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Webforms.Models;

namespace Webforms.BusinessLogic
{
    public class categoriesLogic
    {
        ApplicationDbContext _db = new ApplicationDbContext();

        public IQueryable<Webforms.Models.catagoryModel> ListView1_GetData()
        {
            try { 
            var items = _db.catagories.OrderBy(c => c.CategoryName).AsQueryable<catagoryModel>();

            return items;
            }
            catch (System.NullReferenceException)
            {
                Console.Write("an error has occured");
            }

            catch (System.InvalidOperationException)
            {
                Console.Write("an error has occured");
            }

            return null;
        }

    }
}