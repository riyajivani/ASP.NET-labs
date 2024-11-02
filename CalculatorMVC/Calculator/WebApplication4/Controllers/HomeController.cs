using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplication4.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {





            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }
        public ActionResult GetResult(string num1, string num2, string operation)
        {
            int n1 = Convert.ToInt32(num1);
            int n2 = Convert.ToInt32(num2);
            string res = "<font style=\"color:green\">";
            if (operation == "Add")
            {
                res += "Addition : ";
                res += n1 + n2 + "";
                res += "</font>";
            }
            else if (operation == "Sub")
            {
                res += "Subtraction : ";
                res += n1 - n2 + "";
                res += "</font>";
            }
            else if (operation == "Mul")
            {
                res += "Division : ";
                res += n1 * n2 + "";
                res += "</font>";
            }
           
else if (operation == "Div")
            {
                if (n2 == 0)
                {
                    res = "<font style=\"color:red\">Division :Cannot divide by  zero </ font > " ;
                }
                else
                {
                    res += "Division : ";
                    res += n1 / n2 + "";
                    res += "</font>";
                }
            }
            ViewBag.num1 = n1;
            ViewBag.num2 = n2;
            ViewBag.res = res;
            return View();
        }
        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}