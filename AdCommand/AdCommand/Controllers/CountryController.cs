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
    public class CountryController : Controller
    {
        RRM.Entities.Models.AdcommandContext db = new RRM.Entities.Models.AdcommandContext();

        // GET: /Country/
        public ActionResult Country()
        {
            CountryMaster countrymaster = new CountryMaster();
            var model = countrymaster.GetCountries(db);
            return View(model);
        }

        [ValidateInput(false)]
        public ActionResult CountryCodes()
        {
            CountryMaster countrymaster = new CountryMaster();
            var model = countrymaster.GetCountries(db);
            return PartialView("_CountryCodes", model);
        }

        [HttpPost, ValidateInput(false)]
        public ActionResult CountryCodesAddNew(CountryDetails countryDetails)
        {
            CountryMaster countryMaster = new CountryMaster();
            Country newCountry = new Country();
            var model = db.Countries;
            if (ModelState.IsValid)
            {
                try
                {
                    newCountry.Name = countryDetails.Name;
                    newCountry.CountryCode = countryDetails.CountryCode;
                    newCountry.Created = DateTime.Now;
                    newCountry.Modified = DateTime.Now;
                    newCountry.CreatedBy = Convert.ToInt32(Session["UserID"]);
                    newCountry.ModifiedBy = Convert.ToInt32(Session["UserID"]);
                    model.Add(newCountry);
                    db.SaveChanges();
                }
                catch (Exception e)
                {
                    ViewData["EditError"] = e.Message;
                }
            }
            else
                ViewData["EditError"] = "Please, correct all errors.";
            var countryList = countryMaster.GetCountries(db);
            return PartialView("_CountryCodes", countryList);
        }

        [HttpPost, ValidateInput(false)]
        public ActionResult CountryCodesUpdate(CountryDetails countryDetails)
        {
            CountryMaster countryMaster = new CountryMaster();
            if (ModelState.IsValid)
            {
                try
                {
                    Country editableCountry = (from item in db.Countries where item.ID == countryDetails.ID select item).FirstOrDefault();
                    if (editableCountry != null)
                    {
                        editableCountry.Name = countryDetails.Name;
                        editableCountry.CountryCode = countryDetails.CountryCode;
                        editableCountry.Modified = DateTime.Now;
                        editableCountry.ModifiedBy = Convert.ToInt32(Session["UserID"]);
                        this.UpdateModel(editableCountry);
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

            var countryList = countryMaster.GetCountries(db);
            return PartialView("_CountryCodes", countryList);
        }

        [HttpPost, ValidateInput(false)]
        public ActionResult CountryCodesDelete(System.Int32 ID)
        {
            CountryMaster countryMaster = new CountryMaster();
            var model = db.Countries;
            if (ID >= 0)
            {
                Country editableCountry = (from item in db.Countries where item.ID == ID select item).FirstOrDefault();
                try
                {
                    if (editableCountry != null)
                        model.Remove(editableCountry);
                    db.SaveChanges();
                }
                catch (Exception e)
                {
                    ViewData["EditError"] = e.Message;
                }
            }
            var countryList = countryMaster.GetCountries(db);
            return PartialView("_CountryCodes", countryList);
        }
    }
}