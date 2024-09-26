using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace TH_Lab3.Controllers
{
    public class UserController : Controller
    {
        // GET: Trang Welcome page viết dưới dạng js inline, sử dụng hộp thoại Prompt
        // và document.write để nhập liếu
        public ActionResult Welcome()
        {
            return View();
        }

        public ActionResult Welcome2()
        {
            return View();
        }

        public ActionResult Register()
        {
            return View();
        }
    }
}