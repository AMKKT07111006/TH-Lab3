using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace TH_Lab3.Controllers
{
    public class ShoppingController : Controller
    {
        // GET: Shopping
        public ActionResult ShoppingCart()
        {
            return View();
        }
    }
}