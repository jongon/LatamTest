using LatamTest.Context;
using LatamTest.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using System.Web;

namespace LatamTest.Repository
{
    public class ProductRepository
    {
        private readonly ApplicationDbContext _dbContext;

        private readonly ApplicationMemoryContext _memoryContext;

        public ProductRepository(ApplicationDbContext dbContext, ApplicationMemoryContext memoryContext)
        {
            _dbContext = dbContext;
            _memoryContext = memoryContext;
        }

        public Task<List<Product>> GetAllAsync()
        {
            if (!_memoryContext.Configuration.IsMemoryPersistence) return _dbContext.Products.ToListAsync();
            var products = _memoryContext.Products as List<Product>;
            return Task.Run(() => products ?? _memoryContext.Products.ToList());
        }

        public void Add(Product product)
        {
            if (_memoryContext.Configuration.IsMemoryPersistence)
                _memoryContext.Products.Add(product);
            else
                _dbContext.Products.Add(product);
        }
    }
}