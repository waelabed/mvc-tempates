using mvc_app5.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace mvc_app5.Controllers
{
    public class ServicesController : Controller
    {
        ApplicationDbContext _context = new ApplicationDbContext();
        // GET: Services
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult GetServices()
        {
            var services = _context.Services.ToList().Take(4);
            return PartialView("GetServices",services);
        }

    }
}