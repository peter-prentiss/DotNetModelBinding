using Microsoft.AspNetCore.Mvc;
using DotNetModelBinding.Models;
using System.Linq;

namespace DotNetModelBinding.Controllers
{
    public class HomeController : Controller
    {
        private IRepository repository;
        public HomeController(IRepository repo)
        {
            repository = repo;
        }

        public IActionResult Index(int? id)
        {
            Person person;
            if (id.HasValue && (person = repository[id.Value]) != null)
            {
                return View(person);
            }
            else
            {
                return NotFound();
            }
        }
    }
}