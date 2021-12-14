using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using ShipYard.Models;

namespace ShipYard.Controllers
{
  public class ParcelsController : Controller
  {
    [HttpGet("/parcels")]
    public ActionResult Index()
    {

      List<Parcel> allParcels = Parcel.GetAll();
      return View(allParcels);
    }

    [HttpGet("/parcels/new")]
    public ActionResult CreateForm()
    {
      return View();
    }

    [HttpPost("/parcels")]
    public ActionResult Create(int length, int width, int height, int weight)
    {
      Parcel myParcel = new Parcel(length, width, height, weight);
      return RedirectToAction("Index");
    }

  }
    
}