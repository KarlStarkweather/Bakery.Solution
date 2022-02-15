using System.Collections.Generic;

namespace Bakery.Models
{
  public class Pastry : Inventory
  {
    public int Quantity{get; set; }
    private static Dictionary<int, double> _priceStructure = new Dictionary<int, double>()
    {
      {1, 2},
      {2, 4},
      {3, 5}
    };

    public Pastry(int quant)
    {
      Quantity = quant;
    }

    public double GetPrice()
    {
      return TieredPrice(Quantity, _priceStructure);
    }
  }
}