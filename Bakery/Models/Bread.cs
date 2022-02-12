using System;
using System.Collections.Generic;

namespace Bakery.Models
{

  public class Bread
  {
    public Bread()
    {

    }

    private static Dictionary<int, int> PriceStructure = new Dictionary<int, int>()
    {
      {1, 5},
      {2, 10},
      {3, 10}
    };

  }
}