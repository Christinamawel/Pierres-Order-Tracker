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
      _instances.Add(this);
      Id = _instances.Count;
      Orders = new List<Order> {};
    }
  }
}