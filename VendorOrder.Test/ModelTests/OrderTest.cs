using System;
using System.Collections.Generic;
using VendorOrder.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace VendorOrder.Test
{
  [TestClass]
  public class OrderTests : IDisposable
  {
    public void Dispose()
    {
      Order.ClearAll();
    }

    [TestMethod]
    public void OrderConstructor_CreatesInstanceOfOrder_Order()
    {
      Order order = new Order("x", "x", "x", 1);
      Assert.AreEqual(typeof(Order), order.GetType());
    }

    [TestMethod]
    public void GetValues_ReturnsAllValues_StringInt()
    {
      Order order = new Order("x", "x", "x", 1);
      Assert.AreEqual("x", order.Desc);
      Assert.AreEqual("x", order.Title);
      Assert.AreEqual("x", order.Date);
      Assert.AreEqual(1, order.Price);
    }
  }
}
