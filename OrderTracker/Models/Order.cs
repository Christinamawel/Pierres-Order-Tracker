using System.Collections.Generic;

namespace OrderTracker.Models
{
  public class Order
  {
    public string Date { get; set; }
    public Bread BreadOrder { get; set; }
    public Pastry PastryOrder { get; set; }
    public int BreadTotal { get; set ;}
    public int PastryTotal { get; set; }
    public int TotalPrice { get; set; }
    public int Id { get; }
    private static List<Order> _instances = new List<Order> { };
  
    public Order(string date, int whiteBread, int wheatBread, int sourdough, int pastries)
    {
      Date = date;
      BreadOrder = new Bread(whiteBread, wheatBread, sourdough);
      PastryOrder = new Pastry(pastries);
      BreadTotal = BreadOrder.TotalPrice();
      PastryTotal = PastryOrder.TotalPrice();
      TotalPrice = BreadTotal + PastryTotal;
      _instances.Add(this);
      Id = _instances.Count - 1;
    }

    public static List<Order> GetAll()
    {
      return _instances;
    }

    public static void ClearAll()
    {
      _instances.Clear();
    }

    public static Order Find(int searchId)
    {
      return _instances[searchId];
    }
  }
}