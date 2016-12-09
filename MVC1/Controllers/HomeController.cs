using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVC1.Models;

namespace MVC1.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            List<EmployeeClass> employeeClass = new List<EmployeeClass>()
            {
                new EmployeeClass {Name="Balwanth" , Id=1, Salary=5000 },
                new EmployeeClass {Name="Raamji" , Id=2, Salary=6000 },
                new EmployeeClass {Name="Venu" , Id=3, Salary=5000 }

            };
            ViewBag.List = employeeClass;
            return View();
        }
        public ActionResult Detail()
        {
            List<EmployeeClass> employeeClass = new List<EmployeeClass>()
            {
                new EmployeeClass {Name="Balwanth" , Id=1, Salary=5000 },
                new EmployeeClass {Name="Raamji" , Id=2, Salary=6000 },
                new EmployeeClass {Name="Venu" , Id=3, Salary=5000 }

            };
            return View(employeeClass);
            
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}