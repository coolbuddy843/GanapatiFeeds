using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using GanapatiFeeds2.Models;

namespace GanapatiFeeds2.Controllers
{
    public class AccountsController : Controller
    {
        GanapatiEntities gdb = new GanapatiEntities();
        // GET: Account
        [HttpGet]
        public ActionResult Login()
        {
            return View();
        }

        public ActionResult VerifyUser(Accounts account)
        {
            var acc_detail = gdb.Accounts.Include("Accounts")
                .Single(e => e.Email + e.Password == account.Email + account.Password);
            return View();
        }
    }
}