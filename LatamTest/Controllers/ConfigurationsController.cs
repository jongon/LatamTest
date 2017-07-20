using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;
using LatamTest.Context;
using LatamTest.Repository;

namespace LatamTest.Controllers
{
    public class ConfigurationsController : Controller
    {
        private readonly UnitOfWork _unitOfWork;

        public ConfigurationsController()
        {
            _unitOfWork = new UnitOfWork(new ApplicationContext());
        }

        // GET: Configuration
        [HttpGet]
        public ActionResult ChangePersistence()
        {
            _unitOfWork.ConfigurationRepository.TooglePersistenceMode();

            return RedirectToAction("Index", "Products");
        }
    }
}