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
        private readonly UnitOfWork _unitOfWork;

        public ProductsController()
        {
            _unitOfWork = new UnitOfWork(new ApplicationContext());
        }

        // GET: Products
        [HttpGet]
        public async Task<ActionResult> Index()
        {
            ViewBag.PersistenceMode = _unitOfWork.ConfigurationRepository.IsMemoryPersistence() ? "Memory Persistence" : "Database Persistence";
            var products = await _unitOfWork.ProductRepository.GetAllAsync().ConfigureAwait(false);
            return View(products);
        }

        // GET: Products/Create
        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }

        // POST: Products/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Create([Bind(Include = "Title,Number,Price")] Product product)
        {
            if (!ModelState.IsValid) return View(product);

            _unitOfWork.ProductRepository.Add(product);
            await _unitOfWork.SaveChangesAsync().ConfigureAwait(false);

            return RedirectToAction(nameof(Index));
        }
    }
}
