using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SimpleCharacterCreator.Controllers
{
    public class CharCrtController : Controller
    {
        //
        // GET: /CharCrt/

        public ActionResult AbilityStat()
        {
            ViewBag.Message = "Lets make this easy and use a handy metaphor.";

            return View();
        }

    }
}
