using System.Collections.Generic;
using System;
using Microsoft.AspNetCore.Mvc;
using OrderTracker.Models;

namespace OrderTracker.Controllers
{
    public class VendorsController : Controller
    {
      [HttpGet("/Vendors")]
      public ActionResult Index()
      {
        return View();
      }

      [HttpPost("/Vendors")]
      public ActionResult Create()
      {
        return View();
      }

      [HttpGet("/Vendors/new")]
      public ActionResult New(string vendorName)
      {
        return View();
      }

      // [HttpPost("Vendors/{vendorId}/Orders")]
      // public ActionResult Create()
      // {

      //   return View();
      // }

      [HttpGet("Vendors/{id}")]
      public ActionResult Show()
      {
        return View();
      }

    }
}