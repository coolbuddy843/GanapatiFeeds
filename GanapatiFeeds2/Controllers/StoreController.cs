using GanapatiFeeds2.Models;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace GanapatiFeeds2.Controllers
{
    public class StoreController : Controller
    {
        // GET: Store
        GanapatiEntities gDb = new GanapatiEntities();
        public ActionResult Index()
        {
            var category = gDb.Categories.ToList();
            return View(category);
        }
        [ChildActionOnly]
        public ActionResult CategoryMenu()
        {
            var category = gDb.Categories.ToList();
            return PartialView(category);
        }
        public ActionResult ItemMenu()
        {
            var it = gDb.Items.ToList();
            return PartialView(it);
        }
        public ActionResult Browse(string category)
        {
            var categoryModel = gDb.Categories.Include("Items")
                .Single(c=>c.Name==category);
            return View(categoryModel);
        }
        public ActionResult Details(int id)
        {
            var item = gDb.Items.Find(id);
            return View(item);
        }
    }
}