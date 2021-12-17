using System.Collections.Generic;
using System;
using Microsoft.AspNetCore.Mvc;
using OrderTracker.Models;

namespace OrderTracker.Controllers
{
    public class VendorsController : Controller
    {
      [HttpGet("/vendors")]
      public ActionResult Index()
      {
        List<Vendor> listOfVendors = Vendor.GetAll();
        return View(listOfVendors);
      }

      [HttpPost("/vendors")]
      public ActionResult Create(string name)
      {
        Vendor newVendor = new Vendor(name);
        return RedirectToAction("Index");
      }

      [HttpGet("/vendors/new")]
      public ActionResult New()
      {
        return View();
      }

      [HttpPost("/vendors/{modelId}/orders")]
      public ActionResult Create(int vendorId, string date, int whiteBread, int wheatBread, int sourdough, int pastries)
      {
      Dictionary<string, object> model = new Dictionary<string, object>();
      Vendor foundVendor = Vendor.Find(vendorId);
      Order newOrder = new Order(date, whiteBread, wheatBread, sourdough, pastries);
      foundVendor.AddOrder(newOrder);
      List<Order> vendorOrders = foundVendor.Orders;
      model.Add("orders", vendorOrders);
      model.Add("vendor", foundVendor);
      return View("Show", model);
      }

      [HttpGet("vendors/{id}")]
      public ActionResult Show(int id)
      {
        Dictionary<string, object> model = new Dictionary<string, object>();
        Vendor selectedVendor = Vendor.Find(id);
        List<Order> vendorOrders = selectedVendor.Orders;
        model.Add("vendor", selectedVendor);
        model.Add("orders", vendorOrders);
        return View(model);
      }

    }
}