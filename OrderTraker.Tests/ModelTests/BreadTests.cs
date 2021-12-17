using Microsoft.VisualStudio.TestTools.UnitTesting;
using BreadOrder.Models;
using System;

namespace Bakery.Tests
{
  [TestClass]
  public class BreadTests
  {
    [TestMethod]
    public void BreadConstructor_CreatesInstanceOfBread_Bread()
    {
      //Arrange
      //Act
      Bread testOrder = new Bread(5, 0, 0);
      //Assert
      Assert.AreEqual(typeof(Bread), testOrder.GetType());
    }
    [TestMethod]
    public void GetWhiteBread_ReturnsAmountForWhiteBread_Int()
    {
      //Arrange
      int amount = 5;
      //Act
      Bread testOrder = new Bread(amount, 0, 0);
      int result = testOrder.WhiteBread;
      //Assert
      Assert.AreEqual(amount, result);
    }
    [TestMethod]
    public void TotalPrice_ReturnsTotalPriceforAmountOfBread_Int()
    {
      //Arrange
      int amount = 2;
      int totalPrice = 2 * 5;
      //Act
      Bread testOrder = new Bread(amount, 0, 0);
      int result = testOrder.TotalPrice();
      //Assert
      Assert.AreEqual(totalPrice, result);
    }
    [TestMethod]
    public void TotalPrice_ReturnsTotalPriceAccountingForBuyTwoGetOneSale_Int()
    {
      //Arrange
      int amount = 4;
      int totalPrice = 4 * 5 - 5;
      //Act
      Bread testOrder = new Bread(amount, 0, 0);
      int result = testOrder.TotalPrice();
      //Assert
      Assert.AreEqual(totalPrice, result);
    }
    [TestMethod]
    public void GetWheatBread_ReturnsAmountForWheatBread_Int()
    {
      //Arrange
      int amount = 5;
      //Act
      Bread testOrder = new Bread(0, amount, 0);
      int result = testOrder.WheatBread;
      //Assert
      Assert.AreEqual(amount, result);
    }
    [TestMethod]
    public void GetSourdough_ReturnsAmountForSourdough_Int()
    {
      //Arrange
      int amount = 5;
      //Act
      Bread testOrder = new Bread(0, 0, amount);
      int result = testOrder.Sourdough;
      //Assert
      Assert.AreEqual(amount, result);
    }
    [TestMethod]
    public void TotalPrice_ReturnsTotalPriceAccountingForOtherBreadTypes_Int()
    {
      //Arrange
      // whitebread and wheatbread are $5, sourdough bread is $8
      int whitebread = 4;
      int wheatbread = 2;
      int sourdough = 1;
      int totalPrice = 38 - 10;
      //Act
      Bread testOrder = new Bread(whitebread, wheatbread, sourdough);
      int result = testOrder.TotalPrice();
      //Assert
      Assert.AreEqual(totalPrice, result);
    }
    [TestMethod]
    public void TotalPrice_ReturnsTotalPriceAccountingForSourdoughPrice_Int()
    {
      //Arrange
      // get $8 off price if no other bread can be subtracted from price
      int whitebread = 0;
      int wheatbread = 0;
      int sourdough = 4;
      int totalPrice = 32 - 8;
      //Act
      Bread testOrder = new Bread(whitebread, wheatbread, sourdough);
      int result = testOrder.TotalPrice();
      //Assert
      Assert.AreEqual(totalPrice, result);
    }
  }
}