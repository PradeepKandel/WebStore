using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebStoreNew.Areas.Admin.Models;
using WebStoreNew.Models;

namespace WebStoreNew.Areas.Admin.Controllers
{
    public class HomeController : Controller
    {
        private ApplicationDbContext dbusers = new ApplicationDbContext();
        // GET: Admin/Home
        public ActionResult Index()
        {
            var model = new DashboardViewModel();
            model.Users = dbusers.Users.Count();
            model.Categories = 12;
            model.Products = 100;
            model.Sales = 1200.00f;
            return View(model);
        }
    }
}