using LatamTest.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LatamTest.Context
{
    public class ApplicationMemoryContext
    {
        public static ICollection<Product> Products = new List<Product>();
    }
}