using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EAP_Product_NGUYEN_KHANH_NINH.Models
{
    public class Category
    {
        public int CategoryId { get; set; }

        public string CategoryName { get; set; }

        public virtual ICollection<Product> Products {get; set;}

        public Category()
        {
            this.Products = new HashSet<Product>();
        }
    }
}