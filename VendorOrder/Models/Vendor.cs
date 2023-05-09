using System.Collections.Generic;

namespace VendorOrder.Models
{
  public class Vendor
  {
    public string VendorName {get; set;}
    public string VendorDesc {get; set;}
    private static List<Vendor> _instances = new List<Vendor> { };

    public Vendor(string vendorName, string vendorDesc)
    {
      VendorName = vendorName;
      VendorDesc = vendorDesc;
      _instances.Add(this);
    }

    public static List<Vendor> GetAll()
    {
      return _instances;
    }

  }
}
