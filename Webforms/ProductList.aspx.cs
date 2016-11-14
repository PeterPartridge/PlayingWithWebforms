using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.ModelBinding;
using System.Web.UI;
using System.Web.UI.WebControls;
using Webforms.Models;

namespace Webforms
{
    public partial class ProductList : System.Web.UI.Page
    {
        ApplicationDbContext _db = new ApplicationDbContext();

        protected void Page_Load(object sender, EventArgs e)
        {
            
               
        }

        // The return type can be changed to IEnumerable, however to support
        // paging and sorting, the following parameters must be added:
        //     int maximumRows
        //     int startRowIndex
        //     out int totalRowCount
        //     string sortByExpression
        public IQueryable<Webforms.Models.ProductModel> productListView_GetData([QueryString("id")] int? id)
        {
            if (id != null) { 
            var query = _db.products.OrderBy(c => c.productName).Where(c => c.catagoryId == id).AsQueryable<ProductModel>();

            return query;
            }
            return null;
        }
    }
}