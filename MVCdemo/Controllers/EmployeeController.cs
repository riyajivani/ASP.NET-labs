using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCdemo.Controllers
{
    public class EmployeeController : Controller
    {
        // GET: Employee
        public ActionResult Index(int id)
        {

            EmployeeContext employeeContext = new EmployeeContext();
            employeeContext.Employees.Single(emp=>emp.Id == id);
            return View();
        }
    }
}