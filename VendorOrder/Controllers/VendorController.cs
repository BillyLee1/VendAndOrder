using Microsoft.AspNetCore.Mvc;
using VendorOrder.Models;
using System.Collections.Generic;
using System;

namespace VendorOrder.Controllers
{
  public class VendorsController : Controller
  {
    [HttpGet("/vendors/new")]
    public ActionResult New()
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
      Dictionary<string, object> model = new Dictionary<string, object>();
      Vendor selectedVendor = Vendor.Find(id);
      List<Order> foundOrders = selectedVendor.VendorsOrders;
      model.Add("vendor", selectedVendor);
      model.Add("order", foundOrders);
      return View(model);
    }

    [HttpPost("/vendors/{id}/orders")]
    public ActionResult Create(int id, string orderTitle, string orderDesc, string orderDate, int orderPrice)
    {
      Dictionary<string, object> model = new Dictionary<string, object>();
      Order newOrder = new Order(orderTitle, orderDesc, orderDate, orderPrice);
      Vendor foundVendor = Vendor.Find(id);
      foundVendor.AddOrder(newOrder);
      List<Order> vendorOrders = foundVendor.VendorsOrders;
      model.Add("vendor", foundVendor);
      model.Add("order", vendorOrders);
      return View("Show", model);
    }
  }
}
