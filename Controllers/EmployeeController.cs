using Microsoft.AspNetCore.Mvc;
using WebApplication5.Models;

namespace WebApplication5.Controllers
{
    public class EmployeeController : Controller
    {
        // Simulated in-memory list (you can replace with DB)
        public static List<Employee> employees = new List<Employee>();

        public IActionResult Index()
        {
            return View(employees);
        }

        [HttpGet]
        public IActionResult EmployeeCreate()
        {
            return View();
        }

        [HttpPost]
        public IActionResult EmployeeCreate(Employee emp)
        {
            if (ModelState.IsValid)
            {
                emp.Id = employees.Count + 1; // Simple auto-increment
                employees.Add(emp);
                return RedirectToAction("Index");
            }

            return View(emp);
        }


        [HttpGet]
        public IActionResult EmployeeEdit(int id)
        {
            var employee = employees.FirstOrDefault(e => e.Id == id);
            if (employee == null)
                return NotFound();

            return View(employee);
        }

        [HttpPost]
        public IActionResult EmployeeEdit(Employee updatedEmp)
        {
            var existingEmp = employees.FirstOrDefault(e => e.Id == updatedEmp.Id);
            if (existingEmp == null)
                return NotFound();

            existingEmp.Name = updatedEmp.Name;
            existingEmp.Code = updatedEmp.Code;
            existingEmp.City = updatedEmp.City;
            existingEmp.DOB = updatedEmp.DOB;
            existingEmp.Gender = updatedEmp.Gender;
            existingEmp.Status = updatedEmp.Status;

            return RedirectToAction("Index");
        }



        public IActionResult  EmployeeDetails(int id)
        {
            var employee = employees.FirstOrDefault(e => e.Id == id);
            if (employee == null) return NotFound();
            return View(employee);
        }
           public IActionResult EmployeeDelete(int id)
        {
            var employee = employees.FirstOrDefault(e => e.Id == id);
            if (employee == null) return NotFound();

            employees.Remove(employee);
            return RedirectToAction("Index");
        }



    }
}
