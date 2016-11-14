using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Webforms.Models;

namespace Webforms
{
    public partial class _Default : Page
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
        public IQueryable<Webforms.Models.catagoryModel> ListView1_GetData()
        {
            var items = _db.catagories.OrderBy(c => c.CategoryName).AsQueryable<catagoryModel>();

            return items;
         
        }
    }
}