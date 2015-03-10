using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using CoreLibrary;

namespace _2015MVC.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";
            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";
            return View();
        }

        public ActionResult KunYao(int? n1, int? n2)
        {
            BLL BL = new BLL();
            int? result = BL.Cal(n1,n2);
            ViewBag.Message = result.ToString();
            return View();
        }


    }
}