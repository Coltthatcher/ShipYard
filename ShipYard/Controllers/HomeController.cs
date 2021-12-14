using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using ShipYard.Models;

namespace ShipYard.Controllers
{
  public class HomeController : Controller
  {
    [HttpGet("/")]
    public ActionResult Index()
    {
      return View();
    }
  }
}

