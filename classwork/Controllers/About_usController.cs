using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace classwork.Controllers
{
    public class About_usController : Controller
    {
        // GET: About_us
        
        public ActionResult DisplayAbout()
        {
            return View();
        }

    }
}