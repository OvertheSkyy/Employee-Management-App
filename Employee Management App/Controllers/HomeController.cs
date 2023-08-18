using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using Employee_Management_App.Models;

namespace Employee_Management_App.Controllers
{
    public class HomeController : Controller
    {
        // Read
        public ActionResult Index()
        {
            using (var context = new EmployeeDBContext())
            {
                List<Home> employees = context.Employee_Table.ToList();
                return View(employees);
            }
        }

        // Create
        [HttpPost]
        public ActionResult Create(Home employee)
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

        // Edit
        public ActionResult Edit(int employeeId)
        {
            using (var context = new EmployeeDBContext())
            {
                var employee = context.Employee_Table.Find(employeeId);
                if (employee != null)
                {
                    return View(employee);
                }
            }
            return RedirectToAction("Index");
        }

        [HttpPost]
        public ActionResult Edit(Home employee)
        {
            if (ModelState.IsValid)
            {
                using (var context = new EmployeeDBContext())
                {
                    var employeeToUpdate = context.Employee_Table.Find(employee.Id);
                    if (employeeToUpdate != null)
                    {
                        employeeToUpdate.EmpNo = employee.EmpNo;
                        employeeToUpdate.FirstName = employee.FirstName;
                        employeeToUpdate.LastName = employee.LastName;
                        employeeToUpdate.Birthdate = employee.Birthdate;
                        employeeToUpdate.ContactNo = employee.ContactNo;
                        employeeToUpdate.EmailAddress = employee.EmailAddress;

                        context.SaveChanges();
                    }
                }
            }
            return RedirectToAction("Index");
        }

        // Delete
        [HttpPost]
        public ActionResult Delete(int employeeId)
        {
            using (var context = new EmployeeDBContext())
            {
                var employeeToDelete = context.Employee_Table.Find(employeeId);
                if (employeeToDelete != null)
                {
                    context.Employee_Table.Remove(employeeToDelete);
                    context.SaveChanges();
                }
            }

            return RedirectToAction("Index");
        }
    }
}
