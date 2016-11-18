using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Webforms.Tests
{
   public class TestModel
    {
       
            [ScaffoldColumn(false), Key]
            public int CategoryID { get; set; }

            [Required, StringLength(100), Display(Name = "Name")]
            public string CategoryName { get; set; }

            public DateTime WhenCatagoryWasCreated { get; set; }

            [Display(Name = "Product Description")]
            public string Description { get; set; }
        
    }
}
