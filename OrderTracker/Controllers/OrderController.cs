using Microsoft.AspNetCore.Mvc;
using OrderTracker.Models;
using System.Collections.Generic;

namespace OrderTracker.Controllers
{
  public class OrderController : Controller
  {
    [HttpGet("/Vendors/{vendorId}/Orders/new")]
    public ActionResult New()
    {
      return View();
    }

    [HttpPost("/Orders/delete")]
    public ActionResult DeleteAll()
    {
      return View();
    }

    [HttpGet("/Vendors/{vendorId}/Orders/{OrderId}")]
    public ActionResult Show()
    {
      return View();
    }
  }
}