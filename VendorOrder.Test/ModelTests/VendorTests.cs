using System;
using System.Collections.Generic;
using VendorOrder.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace VendorOrder.Test
{
  [TestClass]
  public class VendorTests : IDisposable
  {
    public void Dispose()
    {
      Vendor.ClearAll();
    }

    [TestMethod]
    public void VendorConstructor_CreatesInstanceOfVendor_Vendor()
    {
      Vendor vendor = new Vendor("x", "x");
      Assert.AreEqual(typeof(Vendor), vendor.GetType());
    }

    [TestMethod]
    public void GetValues_ReturnsAllValues_String()
    {
      Vendor vendor = new Vendor("x", "x");
      Assert.AreEqual("x", vendor.VendorDesc);
      Assert.AreEqual("x", vendor.VendorName);

    }

    [TestMethod]
    public void GetAll_GetsAllVendors_VendorList()
    {
      Vendor vendor1 = new Vendor("x", "x");
      Vendor vendor2 = new Vendor("x", "x");
      List<Vendor> listReturn = new List<Vendor> {vendor1, vendor2};

      List<Vendor> list = Vendor.GetAll();
      CollectionAssert.AreEqual(listReturn, list);
    }

    [TestMethod]
    public void FindId_FindsIdOfObject_Vendor()
    {
      Vendor vendor1 = new Vendor("x", "x");
      Vendor vendor2 = new Vendor("x", "x");
      Vendor find = Vendor.Find(1);
      Assert.AreEqual(vendor1, find);
    }
  }
}
