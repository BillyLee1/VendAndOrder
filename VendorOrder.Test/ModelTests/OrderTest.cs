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

    [TestMethod]
    public void GetAll_GetsAllOrders_OrderList()
    {
      Order order1 = new Order("x", "x", "x", 1);
      Order order2 = new Order("x", "x", "x", 2);
      List<Order> listReturn = new List<Order> {order1, order2};

      List<Order> list = Order.GetAll();
      CollectionAssert.AreEqual(listReturn, list);
    }

    [TestMethod]
    public void FindId_FindsIdOfObject_Order()
    {
      Order order1 = new Order("x", "x", "x", 1);
      Order order2 = new Order("x", "x", "x", 2);
      Order find = Order.FindId(1);
      Assert.AreEqual(order1, find);
    }
  }
}
