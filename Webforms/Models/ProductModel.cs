using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Webforms.Models
{
    public class ProductModel
    {
        [ScaffoldColumn(false), Key]
        public int productId { get; set; }

        [Required,MinLength(5, ErrorMessage ="You need ot add more words"), StringLength(50, ErrorMessage ="You can only have 10000 words"), Display(Name ="Product Name")]
        public string productName{ get; set; }

        [Required, MinLength(5, ErrorMessage = "You need ot add more words"), StringLength(10000, ErrorMessage = "You can only have 10000 words"), Display(Name = "Product Description"), DataType(DataType.MultilineText)]
        public string description  { get; set; }

        public string imagePath { get; set; }

        [Display(Name = "Price"), DataType(DataType.Currency)]
        public double? unitPrice { get; set; }

        public int? catagoryId { get; set; }

        [ForeignKey("catagoryId")]
        public virtual catagoryModel cataory { get; set; }
    }
}