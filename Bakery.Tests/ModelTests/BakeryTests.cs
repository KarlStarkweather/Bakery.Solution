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
    public void BreadConstructor_CalculateOrderOf1_5()
    {
      //Arrange
      int quantity = 1;
      //Act
      Bread breadOrder = new Bread(quantity);
      //Assert
      Assert.AreEqual(breadOrder.Price,5);
    }

    [TestMethod]
    public void BreadConstructor_CalculateOrderOf3_10()
    {
      //Arrange
      int quantity = 3;
      //Act
      Bread breadOrder = new Bread(quantity);
      //Assert
      Assert.AreEqual(breadOrder.Price,10);
    }
      
    [TestMethod]
    public void BreadConstructor_CalculateOrderOf5_20()
    {
      //Arrange
      int quantity = 5;
      //Act
      Bread breadOrder = new Bread(quantity);
      //Assert
      Assert.AreEqual(breadOrder.Price,20);
    }

    [TestMethod]
    public void BreadConstructor_CalculateOrderOf7_25()
    {
      //Arrange
      int quantity = 7;
      //Act
      Bread breadOrder = new Bread(quantity);
      //Assert
      Assert.AreEqual(breadOrder.Price,25);
    }

    [TestMethod]
    public void PastryConstructor_CreateInstanceOfPastry_Pastry()
    {
      //Arrange
      int quantity = 3;
      //Act
      Pastry pastryOrder = new Pastry(quantity);
      //Assert
      Assert.AreEqual(typeof(Pastry),pastryOrder.GetType());
    }

    [TestMethod]
    public void PastryConstructor_CalculateOrderOf5_9()
    {
      //Arrange
      int quantity = 5;
      //Act
      Pastry pastryOrder = new Pastry(quantity);
      //Assert
      Assert.AreEqual(pastryOrder.Price,9);
    }

    [TestMethod]
    public void PastryConstructor_CalculateOrderOf7_12()
    {
      //Arrange
      int quantity = 7;
      //Act
      Pastry pastryOrder = new Pastry(quantity);
      //Assert
      Assert.AreEqual(pastryOrder.Price,12);
    }

  }
}

