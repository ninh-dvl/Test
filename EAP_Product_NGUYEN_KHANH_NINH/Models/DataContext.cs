using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace EAP_Product_NGUYEN_KHANH_NINH.Models
{
    public class DataContext:DbContext
    {

        public virtual DbSet<Category> Categories { get; set; }

        public virtual DbSet<Product> Products { get; set; }

        public DataContext():base(ConfigurationManager.ConnectionStrings["databaseConnection"].ConnectionString)
        {
            string xx = ConfigurationManager.ConnectionStrings["databaseConnection"].ConnectionString;
            if (!Database.Exists())
            {
                Database.Initialize(true);
            }
            DataInitializer dataInitializer = new DataInitializer();
            Database.SetInitializer<DataContext>(dataInitializer);
            dataInitializer.InitDb(this);
        }

    }
}