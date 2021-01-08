using BacaratShabuShabu.Web.Models;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BacaratShabuShabu.Web.Controllers
{
    public class GreetingController : Controller
    {
        // GET: Greeting
        public ActionResult Index(string name)
        {
            var model = new GreetingViewModel();
            model.Name = name ?? "none";
            model.Message = ConfigurationManager.AppSettings["message"];
            return View(model);
        }
    }
}