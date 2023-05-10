using Microsoft.AspNetCore.Mvc;
using VendorOrder.Models;
using System.Collections.Generic;

namespace VendorOrder.Controllers
{
  public class VendorsController : Controller
  {
    [HttpGet("/vendors/new")]
    public ActionResult Vendors()
    {
      return View();
    }

    [HttpGet("/vendors")]
    public ActionResult Index()
    {
      List<Vendor> allVendors = Vendor.GetAll();
      return View(allVendors);
    }

    [HttpPost("/vendors")]
    public ActionResult Create(string vendorName, string vendorDesc)
    {
      Vendor vendor = new Vendor(vendorName, vendorDesc);
      return RedirectToAction("Index");
    }

    [HttpGet("/vendors/{id}")]
    public ActionResult Show(int id)
    {
      Vendor findVendor = Vendor.Find(id);
      return View();
    }
  }
}
