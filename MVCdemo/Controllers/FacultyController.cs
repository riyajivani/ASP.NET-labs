using MVCdemo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCdemo.Controllers
{
    public class FacultyController : Controller
    {
        // GET: Faculty
        public ActionResult Index(int Id)
        {
            FacultyContext context = new FacultyContext();
            Faculty fac = context.faculties.Single(fa => fa.Id == Id);

            
            return View(fac);
        }
    }
}