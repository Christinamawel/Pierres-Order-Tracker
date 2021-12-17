using Microsoft.VisualStudio.TestTools.UnitTesting;
using OrderTracker.Models;
using System.Collections.Generic;
using System;

namespace OrderTracker.Tests
{
  [TestClass]
  public class OrderTests
  {
    [TestMethod]
    public void OrderConstructor_CreatesInstanceOfOrder_Order()
    {
      Order newOrder = new Order("", 0, 0, 0, 0);
      Assert.AreEqual(typeof(Order), newOrder.GetType());
    }

    [TestMethod]
    public void GetDate_ReturnsDate_String()
    {
      //Arrange
      string date = "1/1/21";
      Order newOrder = new Order("1/1/21", 0, 0, 0, 0);

      //Act
      string result = newOrder.Date;

      //Assert
      Assert.AreEqual(date, result);
    }

    [TestMethod]
    public void GetBreadOrder_ReturnsBreadObject_Bread()
    {
      //Arrange
      Bread breadOrder = new Bread( 3, 2, 1);
      Order newOrder = new Order("1/1/21", 3, 2, 1, 0);

      //Act
      int whiteBread = newOrder.BreadOrder.WhiteBread;
      int wheatBread = newOrder.BreadOrder.WheatBread;
      int sourdough = newOrder.BreadOrder.Sourdough;

      //Assert
      Assert.AreEqual(whiteBread, 3);
      Assert.AreEqual(wheatBread, 2);
      Assert.AreEqual(sourdough, 1);
    }

    [TestMethod]
    public void GetPastryOrder_ReturnsPastryObject_Pastry()
    {
      //Arrange
      Pastry pastryOrder = new Pastry(3);
      Order newOrder = new Order("1/1/21", 3, 2, 1, 3);

      //Act
      int pastries = newOrder.PastryOrder.Amount;

      //Assert
      Assert.AreEqual(pastries, 3);
    }
  }
}