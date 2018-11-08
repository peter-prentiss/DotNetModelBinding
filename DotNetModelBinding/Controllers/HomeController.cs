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

        public ViewResult Index(int id) =>
            View(repository[id] ?? repository.People.First());
    }
}