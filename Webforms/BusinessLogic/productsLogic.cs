using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.ModelBinding;
using Webforms.Models;

namespace Webforms.BusinessLogic
{
    public class productsLogic
    {
        ApplicationDbContext _db = new ApplicationDbContext();

        public IQueryable<ProductModel> listProducts([QueryString("id")] int? id)
        {
            try
            {
                   var query = _db.products.OrderBy(c => c.productName).Where(c => c.catagoryId == id).AsQueryable<ProductModel>();

                if (query.Any()) { 
                return query;
                }
                else
                {
                    return null;
                }
            }

            catch (Exception exp)
            {
               
                HttpContext.Current.Server.Transfer("/error.aspx");
            }

            return null;

        }

        
        public ProductModel productGetItem([QueryString("productID")]int? productID)
        {
            try
            {
                var query = _db.products.Where(c => c.productId == productID).SingleOrDefault();
                
                if (query!= null)
                {
                    return query;
                }
                else{
                    return null;
                }
        }

            catch (Exception exp)
            {
                
                HttpContext.Current.Server.Transfer("/error.aspx");
            }

            return null;
        }


    }
}