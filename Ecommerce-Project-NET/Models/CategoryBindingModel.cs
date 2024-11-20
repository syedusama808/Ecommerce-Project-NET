using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Ecommerce_Project_NET.Models
{
    public class CategoryBindingModel
    {
        public int ID { get; set; }
        public string CategoryName { get; set; }
        public string CategoryDescription { get; set; } = null;
        public string CategoryImage { get; set; }
        public int? CategoryID { get; set; }
        public int CreatedOn { get; set; }
        public int? UpdatedOn { get; set; }
        public int Active { get; set; }
    }
}