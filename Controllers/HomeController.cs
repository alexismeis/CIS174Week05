using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MultiPageContactsMeis.Models;


namespace MultiPageContactsMeis.Controllers
{
    public class HomeController : Controller
    {
        private ContactContext context { get; set; }

        public HomeController(ContactContext ctx)
        {
            context = ctx;
        }

        public IActionResult Index()
        {
            var contacts = context.Contacts.ToList();
            return View(contacts);
        }

        // default
        public IActionResult About()
        {
            return Content("Home controller, About action");
        }

        //attribute
        [Route("Privacy")]
        public IActionResult Privacy()
        {
            return Content("Home controller, Privacy action");
        }

        //custom
        public IActionResult List(int num)
        {
            return Content("Home controller, List action, Page: " + num);
        }
    }
}
