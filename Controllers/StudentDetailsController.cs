using Custom_Filter.CustomFilter;
using Custom_Filter.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Custom_Filter.Controllers
{
    [AccessingActionFilter]
    public class StudentDetailsController : Controller
    {
        // GET: StudentDetails
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Index(Contact contact)
        {
            return View();
        }
    }
}