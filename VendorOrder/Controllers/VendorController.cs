using Microsoft.AspNetCore.Mvc;
using VendorOrder.Models;
using System.Collections.Generic;

namespace VendorOrder.Controllers
{
  public class VendorsController : Controller
  {
    [HttpGet("/vendors")]
    public ActionResult Vendors()
    {
      return View();
    }

    [HttpPost("/")]
    public ActionResult Create(string vendorName, string vendorDesc)
    {
      Vendor vendor = new Vendor(vendorName, vendorDesc);
      return RedirectToAction("Index");
    }
  }
}
