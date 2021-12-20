using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace EAP_Product_NGUYEN_KHANH_NINH.Models
{
    public class DataInitializer: DropCreateDatabaseIfModelChanges<DataContext>
    {
        public void InitDb(DataContext dataContext)
        {
            this.Seed(dataContext);
        }
        protected override void Seed(DataContext context)
        {
            base.Seed(context);
            context.Categories.Add(new Category()
            {
                CategoryId = 1,
                CategoryName="abc"
            });
            context.SaveChanges();
            context.Products.Add(new Product()
            {
                ProductId = 0,
                Name ="iphone",
                ReleaseDate=DateTime.Parse("2007-02-02"),
                Quantity=3,
                Price=339,
                CategoryId=1
            }) ;
            context.SaveChanges();
        }
    }
}