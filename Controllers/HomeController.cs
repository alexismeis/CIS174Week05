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

        // Razor Views using View()
        [Route("Privacy")]
        public IActionResult Privacy()
        {
            return View();
        }

        // Razor Views using View(name)
        public IActionResult OtherPrivacy()
        {
            return View("Privacy");
        }
        
        public IActionResult List(int num)
        {
            return Content("Home controller, List action, Page: " + num);
        }
    }
}
