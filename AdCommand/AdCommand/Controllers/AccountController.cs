using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;
using RRM.Entities.Models;
using Web.AdCommand.Models;

namespace Web.AdCommand.Controllers
{
    public class AccountController : Controller
    {
        //
        // GET: /Login/
        AdcommandContext db = new AdcommandContext();
        public ActionResult Login()
        {

            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Login(RRM.Entities.Models.User userNew)
        {
            ViewBag.isLogin = true;
            UserAccount user = new UserAccount();
            if (ModelState.IsValid)
            {
                User val = user.IsValid(userNew.Email, userNew.Password, db);
                if (val != null)
                {
                    Session["UserID"] = val.ID.ToString();
                    Session["GroupID"] = val.GroupID.ToString();
                    Session["Name"] = val.Name.ToString();
                    HttpCookie authCookie = FormsAuthentication.GetAuthCookie(val.Name, false);
                    FormsAuthenticationTicket ticket = FormsAuthentication.Decrypt(authCookie.Value);
                    FormsAuthenticationTicket newTicket = new FormsAuthenticationTicket(ticket.Version, ticket.Name, ticket.IssueDate, ticket.Expiration, ticket.IsPersistent, val.ID.ToString());
                    authCookie.Value = FormsAuthentication.Encrypt(newTicket);
                    Response.Cookies.Add(authCookie);


                    return RedirectToAction("AdProvider", "AdProvider");
                }
                else
                {
                    ModelState.AddModelError("", "Wrong credentials. Please try again.");
                }
            }

            return View(userNew);
        }

        public ActionResult Logout()
        {
            return View();
        }
    }
}