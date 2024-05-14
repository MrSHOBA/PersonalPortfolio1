using PersonalPortfolio1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PersonalPortfolio1.Controllers
{
    public class ContactController : Controller
    {
        // GET: Contact
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Contact(ContactForm model)
        {
            if (ModelState.IsValid)
            {

                TempData["SuccessMessage"] = "Message sent successfully!";
                return RedirectToAction("Contact");
            }
            return View(model);
        }
    }
}
