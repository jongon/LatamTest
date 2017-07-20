using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;

namespace LatamTest.Context
{
    public class ApplicationContext
    {
        public readonly ApplicationDbContext ApplicationDbContext;

        public readonly ApplicationMemoryContext ApplicationMemoryContext;

        public ApplicationContext()
        {
            ApplicationDbContext = new ApplicationDbContext();
            ApplicationMemoryContext = ApplicationMemoryContext.GetInstance();
        }

        public Task SaveChangesAsync()
        {
            return ApplicationDbContext.SaveChangesAsync();
        }

        public void Dispose()
        {
            ApplicationDbContext.Dispose();
        }
    }
}