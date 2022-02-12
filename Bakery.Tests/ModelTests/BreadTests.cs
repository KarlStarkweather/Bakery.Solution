using Microsoft.VisualStudio.TestTools.UnitTesting;
using Bakery.Models;

namespace Bakery.Tests
{
  [TestClass]
  public class BakeryTests
  {
    [TestMethod]
    public void BreadConstructor_CreateInstanceOfBread_Bread()
    {
      //Arrange
      int quantity = 3;
      //Act
      Bread breadOrder = new Bread(quantity);
      //Assert
      Assert.AreEqual(typeof(Bread),breadOrder.GetType());
    }

    [TestMethod]
    public void BreadConstructor_AssignQuantOfBread_3()
    {
      //Arrange
      int quantity = 3;
      //Act
      Bread breadOrder = new Bread(quantity);
      //Assert
      Assert.AreEqual(breadOrder.Quantity,3);
    }

    [TestMethod]
    public void BreadConstructor_CalculateOrder_5()
    {
      //Arrange
      int quantity = 1;
      //Act
      Bread breadOrder = new Bread(quantity);
      //Assert
      Assert.AreEqual(breadOrder.Price,5);
    }

[TestMethod]
    public void BreadConstructor_CalculateOrder_10()
    {
      //Arrange
      int quantity = 3;
      //Act
      Bread breadOrder = new Bread(quantity);
      //Assert
      Assert.AreEqual(breadOrder.Price,10);
    }
  }
}

