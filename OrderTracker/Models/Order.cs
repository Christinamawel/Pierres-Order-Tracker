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
    public int Price { get; set; }
  
    public Order(string date, int whiteBread, int wheatBread, int sourdough, int pastries)
    {
      Date = date;
      BreadOrder = new Bread(whiteBread, wheatBread, sourdough);
      PastryOrder = new Pastry(pastries);
      BreadTotal = BreadOrder.TotalPrice();
      PastryTotal = 0;
    }
  }
}