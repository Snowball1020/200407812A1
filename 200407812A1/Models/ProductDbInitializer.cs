using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace _200407812A1.Models
{
    public class ProductDbInitializer : DropCreateDatabaseAlways<ApplicationDbContext>
    {

        protected override void Seed(ApplicationDbContext context)
        {
            Products def = new Products
            {
                Name = "Beeff",
                Price = 5,
                Description = "Beautiful",
                Nutritional_Information = "Vitamin Z",
                Weight = 2,
                Brand = "Whole Foods",
                TypeOfAnimalFoodIsFor = "Dog"

            };

            context.Products.Add(def);


            base.Seed(context);
        }


    }
}