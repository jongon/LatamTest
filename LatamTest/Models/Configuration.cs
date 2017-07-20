using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LatamTest.Models
{
    public class Configuration
    {
        public static bool MemoryPersistance = false;

        public bool IsMemoryPersistance
        {
            get => MemoryPersistance;

            set => MemoryPersistance = value;
        }
    }
}