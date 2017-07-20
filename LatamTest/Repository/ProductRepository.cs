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

        private readonly ApplicationMemoryContext _memoryContext;

        public ProductRepository(ApplicationDbContext context)
        {
            _dbContext = context;
        }

        public ProductRepository(ApplicationMemoryContext context)
        {
            _memoryContext = context;
        }

        private bool IsMemoryPersistant => _dbContext == null;

        public IList<Product> GetAll()
        {
            if (!IsMemoryPersistant) return _dbContext.Products.ToList();
            var products = _memoryContext.Products as List<Product>;
            return products ?? _memoryContext.Products.ToList();
        }

        public void Add(Product product)
        {
            if (IsMemoryPersistant)
                _memoryContext.Products.Add(product);
            else
                _dbContext.Products.Add(product);
        }
    }
}