using LatamTest.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;

namespace LatamTest.Repository
{
    public class UnitOfWork
    {
        private readonly ApplicationContext _context;

        public ProductRepository ProductRepository { get; set; }

        public ConfigurationRepository ConfigurationRepository { get; set; }

        public UnitOfWork(ApplicationContext context)
        {
            _context = context;
            ProductRepository = new ProductRepository(_context.ApplicationDbContext, _context.ApplicationMemoryContext);
            ConfigurationRepository = new ConfigurationRepository(_context.ApplicationMemoryContext);
        }

        public Task SaveChangesAsync()
        {
            return _context.SaveChangesAsync();
        }

        public void Dispose()
        {
            _context.Dispose();
        }
    }
}