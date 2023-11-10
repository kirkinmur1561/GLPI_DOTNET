using ControlCalendar.Models.Servers;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace ControlCalendar.Controllers;

[Controller]
public class SettingsController : Controller
{
    [HttpGet]
    public IActionResult Index()
    {
        return View();
    }
    
    [HttpPost,ValidateAntiForgeryToken]
    public IActionResult Index([FromForm]Settings settings)
    {
        return View();
    }
}