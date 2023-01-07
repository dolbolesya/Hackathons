using Microsoft.AspNetCore.Mvc;

namespace Hackathons.Controllers;

public class HomeController : Controller
{
    // GET
    public IActionResult Index()
    {
        return View();
    }
}