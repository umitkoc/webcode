using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using umitkoc.Models;

namespace umitkoc.Controllers;

public class HomeController : Controller
{
  

   
    public IActionResult Index()
    {
        return View();
    }

   
}
