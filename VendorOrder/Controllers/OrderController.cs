using Microsoft.AspNetCore.Mvc;
using VendorOrder.Models;
using System.Collections.Generic;
using System;

namespace VendorOrder.Controllers
{
  public class OrdersController : Controller
  {
    [HttpGet("/vendors/{id}/orders/new")]
    public ActionResult New(int id)
    {
      Vendor newVendor = Vendor.Find(id);
      return View(newVendor);
    }
    
    [HttpGet("/vendors/{id}/orders/{orderId}")]
    public ActionResult Show(int id, int orderId)
    {
      Vendor findVendor = Vendor.Find(id);
      Order findOrder = Order.Find(orderId);
      Dictionary<string, object> model = new Dictionary<string, object>();
      model.Add("order", findOrder);
      model.Add("vendor", findVendor);
      return View(model);
    }
    

  }
}
