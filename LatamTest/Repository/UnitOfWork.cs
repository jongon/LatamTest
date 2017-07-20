using LatamTest.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LatamTest.Repository
{
    public class UnitOfWork
    {
        private readonly ApplicationDbContext _dbContext;

        public ProductRepository ProductRepository { get; set; }

        public ConfigurationRepository ConfigurationRepository { get; set; }

        public UnitOfWork(ApplicationDbContext context)
        {
            _dbContext = context;
            ProductRepository = new ProductRepository(_dbContext);
        }

        public UnitOfWork(ApplicationMemoryContext context)
        {
            ProductRepository = new ProductRepository(context);
            ConfigurationRepository = new ConfigurationRepository(context);
        }

        public void SaveChanges()
        {
            _dbContext?.SaveChanges();
        }

        public void Dispose()
        {
            _dbContext?.Dispose();
        }
    }
}