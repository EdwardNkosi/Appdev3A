using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace gomo.Models.ShoppingCart
{
    public class DepartmentModel
    {
        public int Department_ID { get; set; }
        public string Department_Name { get; set; }
        public string Description { get; set; }
    }
  
}