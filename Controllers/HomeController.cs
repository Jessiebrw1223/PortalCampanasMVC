using Microsoft.AspNetCore.Mvc;

namespace PortalCampanasMVC.Controllers;

public class HomeController : Controller
{
    public IActionResult Index() => RedirectToAction("Index", "Campanas");
}
