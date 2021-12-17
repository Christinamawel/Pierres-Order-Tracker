using Microsoft.VisualStudio.TestTools.UnitTesting;
using OrderTracker.Models;
using System;

namespace OrderTracker.Tests
{
  [TestClass]
  public class PastryTests
  {
    [TestMethod]
    public void PastryConstructor_CreatesInstanceOfPastry_Pastry()
    {
      //Arrange
      //Act
      Pastry testOrder = new Pastry(5);
      //Assert
      Assert.AreEqual(typeof(Pastry), testOrder.GetType());
    }
    [TestMethod]
    public void GetAmount_ReturnsAmount_Int()
    {
      //Arrange
      int amount = 5;
      //Act
      Pastry testOrder = new Pastry(amount);
      int result = testOrder.Amount;
      //Assert
      Assert.AreEqual(amount, result);
    }
    [TestMethod]
    public void TotalPrice_ReturnsTotalPriceforAmountOfPastry_Int()
    {
      //Arrange
      int amount = 2;
      int totalPrice = 2 * 2;
      //Act
      Pastry testOrder = new Pastry(amount);
      int result = testOrder.TotalPrice();
      //Assert
      Assert.AreEqual(totalPrice, result);
    }
    [TestMethod]
    public void TotalPrice_ReturnsTotalPriceAccountingForThridIsHalfOffSale_Int()
    {
      //Arrange
      int amount = 4;
      int totalPrice = 4 * 2 - 1;
      //Act
      Pastry testOrder = new Pastry(amount);
      int result = testOrder.TotalPrice();
      //Assert
      Assert.AreEqual(totalPrice, result);
    }
  }
}