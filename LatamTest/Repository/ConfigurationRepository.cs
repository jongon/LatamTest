using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using LatamTest.Context;

namespace LatamTest.Repository
{
    public class ConfigurationRepository
    {
        private readonly ApplicationMemoryContext _memoryContext;


        public ConfigurationRepository(ApplicationMemoryContext context)
        {
            _memoryContext = context;
        }

        public bool IsMemoryPersistence() => _memoryContext.Configuration.IsMemoryPersistence;

        public void TooglePersistenceMode()
        {
            if (_memoryContext.Configuration.IsMemoryPersistence)
            {
                _memoryContext.Configuration.IsMemoryPersistence = false;
                return;
            }

            _memoryContext.Configuration.IsMemoryPersistence = true;
        }
    }
}