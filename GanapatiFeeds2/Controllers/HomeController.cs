using GanapatiFeeds2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace GanapatiFeeds2.Controllers
{
    public class HomeController : Controller
    {
        GanapatiEntities StoreDB = new GanapatiEntities();
        private List<Item> GetAllSellingItems()
        {
            return StoreDB.Items
                .ToList();
        }
        public ActionResult Index()
        {
            var items = GetAllSellingItems();
            return View(items);
        }

        public ActionResult About()
        {
            ViewBag.Message = "We can provide you all the fertilizers and animal feeds for you farming";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "You can contact us";

            return View();
        }
    }
}