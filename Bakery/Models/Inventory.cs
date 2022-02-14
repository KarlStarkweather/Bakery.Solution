using System.Collections.Generic;

namespace Bakery.Models
{

  public class Inventory
  {

    public double TieredPrice(int quantity, Dictionary<int,double> priceStructure)
    {
      double price = 0;
      int listedPrices = priceStructure.Count;

      if (quantity>listedPrices)
      {
        int remainingPrices = quantity % listedPrices;
        int maxDiscounts = (quantity - remainingPrices) / listedPrices;
        price = priceStructure[listedPrices] * maxDiscounts;
        price += priceStructure[remainingPrices];  
      }
      else if (quantity>0)
      {
        price = priceStructure[quantity];
      }
 
      return price;
    }
  }
}