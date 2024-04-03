using Microsoft.AspNetCore.Mvc;
using EmployeeProject.Models;

namespace EmployeeProject.Controllers
{
    public class EmployeeController : Controller
    {
        public IActionResult Index()
        {
            EmployeeModel emp = new EmployeeModel() { Id=1, Name = "Success"};
            return View(emp);
        }
    }
}
