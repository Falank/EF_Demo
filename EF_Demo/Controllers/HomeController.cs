using EF_Demo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace EF_Demo.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            EmployeeContext data = new EmployeeContext();
            List<Employee> employees = data.Employees.ToList();
            return View(employees);
        }
        [HttpPost]
        public ActionResult AddEmployee(string first_name, string last_name)
        {
            using (var data = new EmployeeContext())
            {
                data.Employees.Add(new Employee
                {
                    first_name = first_name,
                    last_name = last_name
                });
                data.SaveChanges();
            }
            return RedirectToAction("Index");
        }
        [HttpPost]
        public ActionResult DeleteEmployee(int id)
        {
            using (var data = new EmployeeContext())
            {
                var delete = data.Employees.SingleOrDefault(a => a.id == id);
                data.Employees.Remove(delete);
                data.SaveChanges();
            }
            return RedirectToAction("Index");
        }
    }
}