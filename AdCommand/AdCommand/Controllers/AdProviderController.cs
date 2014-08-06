using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DevExpress.Web.Mvc;
using Web.AdCommand.Models;

namespace Web.AdCommand.Controllers
{
    public class AdProviderController : Controller
    {

        RRM.Entities.Models.AdcommandContext db = new RRM.Entities.Models.AdcommandContext();

        // GET: /AdProvider/
        public ActionResult AdProvider()
        {
            ViewBag.isLogin = false;
            AdProviderMaster adProviderMaster = new AdProviderMaster();
            var model = adProviderMaster.GetAdProviders(db);
            return View(model);
        }

        [ValidateInput(false)]
        public ActionResult AdProviderPartial()
        {
            var model = db.AdProviders;
            return PartialView("_AdProviderPartial", model.ToList());
        }

        [HttpPost, ValidateInput(false)]
        public ActionResult AdProviderPartialAddNew(RRM.Entities.Models.AdProvider item)
        {
            var model = db.AdProviders;
            if (ModelState.IsValid)
            {
                try
                {
                    model.Add(item);
                    db.SaveChanges();
                }
                catch (Exception e)
                {
                    ViewData["EditError"] = e.Message;
                }
            }
            else
                ViewData["EditError"] = "Please, correct all errors.";
            return PartialView("_AdProviderPartial", model.ToList());
        }
        [HttpPost, ValidateInput(false)]
        public ActionResult AdProviderPartialUpdate(RRM.Entities.Models.AdProvider item)
        {
            var model = db.AdProviders;
            if (ModelState.IsValid)
            {
                try
                {
                    var modelItem = model.FirstOrDefault(it => it.ID == item.ID);
                    if (modelItem != null)
                    {
                        this.UpdateModel(modelItem);
                        db.SaveChanges();
                    }
                }
                catch (Exception e)
                {
                    ViewData["EditError"] = e.Message;
                }
            }
            else
                ViewData["EditError"] = "Please, correct all errors.";
            return PartialView("_AdProviderPartial", model.ToList());
        }
        [HttpPost, ValidateInput(false)]
        public ActionResult AdProviderPartialDelete(System.Int32 ID)
        {
            var model = db.AdProviders;
            if (ID >= 0)
            {
                try
                {
                    var item = model.FirstOrDefault(it => it.ID == ID);
                    if (item != null)
                        model.Remove(item);
                    db.SaveChanges();
                }
                catch (Exception e)
                {
                    ViewData["EditError"] = e.Message;
                }
            }
            return PartialView("_AdProviderPartial", model.ToList());
        }
	}
}