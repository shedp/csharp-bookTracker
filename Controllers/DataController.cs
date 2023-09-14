using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using csharp_intro.Models;

namespace csharp_intro.Controllers;

public class DataController : Controller
{
    public IActionResult Index()
    {
        return View();
    }
}
