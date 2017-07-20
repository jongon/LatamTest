using LatamTest.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LatamTest.Repository
{
    public class UnitOfWork
    {
        public static bool IsMemoryStorage = false;

        private readonly ApplicationDbContext _dbContext;

        public int MyProperty { get; set; }
    }
}