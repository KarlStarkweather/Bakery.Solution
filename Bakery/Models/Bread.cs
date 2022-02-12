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
      if (quant>PriceStructure.Count)
      {
        int dealRemainder = quant % PriceStructure.Count;
        int dealBase = quant - dealRemainder;
        Price = PriceStructure[dealBase];
        Price += PriceStructure[dealRemainder];  
      }
      else
      {
        Price = PriceStructure[Quantity];
      }

    }

    private static Dictionary<int, int> PriceStructure = new Dictionary<int, int>()
    {
      {1, 5},
      {2, 10},
      {3, 10}
    };

  }
}