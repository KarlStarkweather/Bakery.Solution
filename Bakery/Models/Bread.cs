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
    }

    private static Dictionary<int, int> PriceStructure = new Dictionary<int, int>()
    {
      {1, 5},
      {2, 10},
      {3, 10}
    };

  }
}