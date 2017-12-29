using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BookStore.Controllers
{
    public class BookShopController : Controller
    {
        // GET: BookShop
        public ActionResult Index()
        {
            return View();
        }
    }
}