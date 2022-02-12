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
      int quantity = 2;
      //Act
      Bread breadOrder = new Bread(quantity);
      //Assert
      Assert.AreEqual(typeof(Bread),breadOrder.GetType());
    }


  }
}

