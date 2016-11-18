using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.ModelBinding;
using System.Web.UI;
using System.Web.UI.WebControls;
using Webforms.BusinessLogic;
using Webforms.Models;

namespace Webforms
{
    public partial class ProductList : System.Web.UI.Page
    {
        

        protected void Page_Load(object sender, EventArgs e)
        {

            
        }

        protected void productListView_CallingDataMethods(object sender, CallingDataMethodsEventArgs e)
        {
            
            e.DataMethodsObject = new productsLogic();
        }
    }
}