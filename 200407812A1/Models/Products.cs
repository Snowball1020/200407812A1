using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace _200407812A1.Models
{
    public class Products
    {
        [Key]
        public String Name { get; set; }
        public decimal Price { get; set; }
        public String Description { get; set; }
        public String Nutritional_Information { get; set; }
        public decimal Weight { get; set; }
        public String Brand { get; set; }
        public String TypeOfAnimalFoodIsFor { get; set; }

    }

    

}