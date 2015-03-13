using CodePound.Demos.SpaWithSignalR.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CodePound.Demos.SpaWithSignalR.Controllers
{
    public class HomeController : Controller
    {
        private MessageContext db = new MessageContext();

        // GET: Home
        public ActionResult Index()
        {
            return View(db.Messages.OrderByDescending(x => x.Id).ToList());
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}