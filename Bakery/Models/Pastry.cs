using System.Collections.Generic;

namespace Bakery.Models
{

  public class Pastry : Inventory
  {
    public int Quantity{get; set; }
 
    public Pastry(int quant)
    {
      Quantity = quant;
    }

    public double GetPrice()
    {
      return TieredPrice(Quantity, PriceStructure);
    }

    private static Dictionary<int, double> PriceStructure = new Dictionary<int, double>()
    {
      {1, 2},
      {2, 4},
      {3, 5}
    };

  }
}