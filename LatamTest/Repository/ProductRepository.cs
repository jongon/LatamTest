using LatamTest.Context;
using LatamTest.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LatamTest.Repository
{
    public class ProductRepository
    {
        private readonly ApplicationDbContext _dbContext;

        public ProductRepository(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public Prod

        public void Add(Product product)
        {
            if (_dbContext == null) 
                
        }
    }
}