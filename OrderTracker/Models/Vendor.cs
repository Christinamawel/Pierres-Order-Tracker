using System.Collections.Generic;

namespace OrderTracker.Models
{
  public class Vendor
  {
    public string Name { get; set; }
    public int Id { get; }
    public List<Order> Orders { get; set; }
    private static List<Vendor> _instances = new List<Vendor> {};

    public Vendor(string name)
    {
      Name = name;
      _instances.Add(this);
      Id = _instances.Count - 1;
      Orders = new List<Order> {};
    }

    public static List<Vendor> GetAll()
    {
      return _instances;
    }

    public static void ClearAll()
    {
    _instances.Clear();
    }

    public static Vendor Find(int searchId)
    {
      return _instances[searchId];
    }

    public void AddOrder(Order order)
    {
      Orders.Add(order);
    }
  }
}