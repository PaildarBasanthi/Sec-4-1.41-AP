using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;


namespace Phase3Section3._38.Controllers
{
    public class HomeController : Controller
    { 
        public object Session { get; private set; }

        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Index(FormCollection form)
        {
            int age = Convert.ToInt16(form["age"]);
            return View();
        }


        public ActionResult Index2()
        {
            return View();
        }

        [HttpPost]
        [HandleError(View = "Error")]
        public ActionResult Index2(FormCollection form)
        {
            try
            {
                int age = Convert.ToInt16(form["age"]);
            }
            catch (Exception ex)
            {
                
                throw ex;
            }
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
    }

    internal class HandleErrorAttribute : Attribute
    {
        public string View;
    }
}

