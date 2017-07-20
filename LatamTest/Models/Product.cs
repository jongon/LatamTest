using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LatamTest.Models
{
    public class Product
    {
        public int ProductId { get; set; }

        public string Title { get; set; }

        public int Number { get; set; }

        public decimal Price { get; set; }
    }
}