using Microsoft.AspNetCore.Mvc;
using VendorOrder.Models;
using System.Collections.Generic;

namespace VendorOrder.Controllers
{
  public class OrderController : Controller
  {
    [HttpGet("/vendors/{id}/orders/new")]
    public ActionResult NewOrder(int id)
    {
      Vendor newVendor = Vendor.Find(id);
      return View(newVendor);
    }
  }
}
