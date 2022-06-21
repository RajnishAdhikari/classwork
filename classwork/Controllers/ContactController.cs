using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace classwork.Controllers
{
    public class ContactController : Controller
    {
        // GET: Contact

        
        public ActionResult DisplayContact()
        {
            return View();
        }
    }
}