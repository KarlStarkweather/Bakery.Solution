using System.Collections.Generic;

namespace Bakery.Models
{

  public class Bread : Inventory
  {
    public int Quantity{get; set; }
 
    public Bread(int quant)
    {
      Quantity = quant;
    }
    
    public double GetPrice()
    {
      return TieredPrice(Quantity, PriceStructure);
    }

    private static Dictionary<int, double> PriceStructure = new Dictionary<int, double>()
    {
      {1, 5},
      {2, 10},
      {3, 10}
    };

  }
}