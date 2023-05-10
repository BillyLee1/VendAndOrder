using System.Collections.Generic;

namespace VendorOrder.Models
{
  public class Order
  {
    public string Title { get; set; }
    public string Desc {get; set; }
    public string Date { get; set; }
    public int Price { get; set; }
    public int Id {get; }
    private static List<Order> _orderInstances = new List<Order> { };

    public Order(string orderTitle, string orderDesc, string orderDate, int orderPrice, int orderId )
    {
      Title = orderTitle;
      Desc = orderDesc;
      Date = orderDate;
      Price = orderPrice;
      _orderInstances.Add(this);
      Id = _orderInstances.Count;
    }

    public static List<Order> GetAll()
    {
      return _orderInstances;
    }

    public static Order Find(int searchId)
    {
      return _orderInstances[searchId - 1];
    }
  }

  
}
