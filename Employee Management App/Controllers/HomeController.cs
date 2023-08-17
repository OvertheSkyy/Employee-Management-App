using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using Employee_Management_App.Models;

namespace Employee_Management_App.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            using (var context = new EmployeeDBContext())
            {
                List<Home> employees = context.Employee_Table.ToList();
                return View(employees);
            }
        }

        [HttpPost]
        public ActionResult InsertEmployee(Home employee)
        {
            if (ModelState.IsValid)
            {
                using (var context = new EmployeeDBContext())
                {
                    context.Employee_Table.Add(employee);
                    context.SaveChanges();
                }
            }

            return RedirectToAction("Index");
        }
    }
}
