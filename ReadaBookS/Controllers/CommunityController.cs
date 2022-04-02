using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ReadaBookS.Models;

namespace ReadaBookS.Controllers
{
    public class CommunityController : Controller
    {
        Book_Order db = new Book_Order();
        // GET: Community
        public ActionResult Index()
        {
            return View(db.AspNetUsers.ToList());
        }
    }
}