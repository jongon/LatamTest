using LatamTest.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LatamTest.Context
{
    public class ApplicationMemoryContext
    {
        private ApplicationMemoryContext() { }

        private static readonly ApplicationMemoryContext Instance = new ApplicationMemoryContext();

        public static ApplicationMemoryContext GetInstance()
        {
            return Instance;
        }

        public ICollection<Product> Products = new List<Product>();

        public Configuration Configuration = new Configuration();
    }
}