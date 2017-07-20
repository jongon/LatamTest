using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using System.Net;
using System.Web;
using System.Web.Mvc;
using LatamTest.Context;
using LatamTest.Models;
using LatamTest.Repository;

namespace LatamTest.Controllers
{
    public class ProductsController : Controller
    {
        private readonly ApplicationDbContext _dbContext;

        private readonly ApplicationMemoryContext _memoryContext;

        public ProductsController()
        {
            _dbContext = new ApplicationDbContext();
            _memoryContext = ApplicationMemoryContext.GetInstance();
        }

        // GET: Products
        public async Task<ActionResult> Index()
        {
            var unitOfWork = new UnitOfWork();
            return View(await db.Products.ToListAsync());
        }

        // GET: Products/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Products/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Create([Bind(Include = "Title,Number,Price")] Product product)
        {
            if (ModelState.IsValid)
            {
                db.Products.Add(product);
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }

            return View(product);
        }
    }
}
