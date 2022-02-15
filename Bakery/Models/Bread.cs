using System.Collections.Generic;

namespace Bakery.Models
{
  public class Bread : Inventory
  {
    public int Quantity{get; set; }
    private static Dictionary<int, double> _priceStructure = new Dictionary<int, double>()
    {
      {1, 5},
      {2, 10},
      {3, 10}
    };
 
    public Bread(int quant)
    {
      Quantity = quant;
    }
    
    public double GetPrice()
    {
      return TieredPrice(Quantity, _priceStructure);
    }
  }
}