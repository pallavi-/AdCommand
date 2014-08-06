using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using RRM.Entities.Models;
using DevExpress.Web.Mvc;
using Web.AdCommand.Models;
namespace Web.AdCommand.Controllers
{
    public class HomeController : Controller
    {
        // GET : /AdProvider
        public ActionResult Index()
        {
            return View();
        }
	}
}