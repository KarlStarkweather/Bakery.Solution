using System;
using System.Collections.Generic;

namespace Bakery.Models
{

  public class Pastry
  {
    public int Quantity{get; set; }
    public int Price{get; set; }

    public Pastry(int quant)
    {
      Quantity = quant;
      if (quant>PriceStructure.Count)
      {
        int max = PriceStructure.Count;
        int dealRemainder = quant % max;
        int dealBaseMultiplier = (quant - dealRemainder) / max;
        Price = PriceStructure[max] * dealBaseMultiplier;
        Price += PriceStructure[dealRemainder];  
      }
      else
      {
        Price = PriceStructure[Quantity];
      }

    }

    private static Dictionary<int, int> PriceStructure = new Dictionary<int, int>()
    {
      {1, 2},
      {2, 4},
      {3, 5}
    };

  }
}