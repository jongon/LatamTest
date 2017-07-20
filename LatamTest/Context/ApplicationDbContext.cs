using LatamTest.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace LatamTest.Context
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext() : base("LatamConnection")
        {
            //Configuration.LazyLoadingEnabled = false;
        }

        public static ApplicationDbContext Create()
        {
            return new ApplicationDbContext();
        }

        public virtual IDbSet<Product> Products { get; set; }
    }
}