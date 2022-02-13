using System;
using System.Collections.Generic;

namespace Bakery.Models
{

  public class Bread
  {
    public int Quantity{get; set; }
    public int Price{get; set; }

    public Bread(int quant)
    {
      Quantity = quant;
      if (quant>(PriceStructure.Count-1))
      {
        int max = PriceStructure.Count-1;
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
      {0, 0},
      {1, 5},
      {2, 10},
      {3, 10}
    };

  }
}