using System;
using Bakery.Models;

namespace Bakery
{
  public class Program
  {
    public static void Main()
    {
      Console.WriteLine("Welcome to Pierre's Bakery!");
      Console.WriteLine("Enter the number of loaves of bread you want to order:");
      int qBread = Convert.ToInt32(Console.ReadLine());
      Bread breadOrder = new Bread(qBread);
      Console.WriteLine("Enter the number of Pastries you want to order:");
      int qPastry = Convert.ToInt32(Console.ReadLine());
      Pastry pastryOrder = new Pastry(qPastry);
      Console.WriteLine("OK I think I've got it.");
      Console.WriteLine("That's " + qBread + " loaves of bread for $" + breadOrder.Price);
      Console.WriteLine("and " + qPastry + " pastries for $" + pastryOrder.Price);
      Console.WriteLine("for a total of: $" + (breadOrder.Price + pastryOrder.Price));    
    }
  }
}