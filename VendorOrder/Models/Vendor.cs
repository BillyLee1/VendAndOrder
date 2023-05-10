using System.Collections.Generic;

namespace VendorOrder.Models
{
  public class Vendor
  {
    public string VendorName {get; set;}
    public string VendorDesc {get; set;}
    public int Id {get; }
    private static List<Vendor> _instances = new List<Vendor> { };
    public List<Order> VendorsOrders {get; set;}

    public Vendor(string vendorName, string vendorDesc)
    {
      VendorName = vendorName;
      VendorDesc = vendorDesc;
      _instances.Add(this);
      Id = _instances.Count;
      VendorsOrders = new List<Order>{};
    }

    public static List<Vendor> GetAll()
    {
      return _instances;
    }

    public static Vendor Find(int searchId)
    { 
      return _instances[searchId - 1];
    }

    public void AddOrder(Order order)
    {
      VendorsOrders.Add(order);
    }
  }
}
