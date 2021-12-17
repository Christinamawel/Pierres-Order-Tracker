namespace PastryOrder.Models
{
  public class Pastry
  {
    public int Amount { get; set; }

    public Pastry(int amount)
    {
      Amount = amount;
    }

    public int TotalPrice()
    {
      int salePastrys = Amount / 3;
      return Amount * 2 - salePastrys;
    }
  }
}