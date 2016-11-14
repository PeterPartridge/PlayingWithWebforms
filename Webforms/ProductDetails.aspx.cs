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
    public partial class ProductDetails : System.Web.UI.Page
    {
        ApplicationDbContext _db = new ApplicationDbContext();

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        // The id parameter should match the DataKeyNames value set on the control
        // or be decorated with a value provider attribute, e.g. [QueryString]int id
        public Webforms.Models.ProductModel product_GetItem([QueryString("productID")]int? productID)
        {
            var query = _db.products.Where(c => c.productId == productID).SingleOrDefault();
            return query;
        }
    }
}