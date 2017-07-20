using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LatamTest.Models
{
    public class Configuration
    {
        public static bool MemoryPersistence = false;

        public bool IsMemoryPersistence
        {
            get => MemoryPersistence;

            set => MemoryPersistence = value;
        }
    }
}