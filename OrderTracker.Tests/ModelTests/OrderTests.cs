using Microsoft.VisualStudio.TestTools.UnitTesting;
using OrderTracker.Models;
using System.Collections.Generic;
using System;

namespace OrderTracker.Tests
{
  [TestClass]
  public class OrderTests : IDisposable
  {
    public void Dispose()
    {
      Order.ClearAll();
    }

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
      Order newOrder = new Order("1/1/21", 3, 2, 1, 3);

      //Act
      int pastries = newOrder.PastryOrder.Amount;

      //Assert
      Assert.AreEqual(pastries, 3);
    }

    [TestMethod]
    public void GetBreadTotal_ReturnsTotalBreadPrice_Int()
    {
      //Arrange
      Order newOrder = new Order("1/1/21", 3, 2, 1, 3);
      Bread newBreadOrder = new Bread(3, 2, 1);

      //Act
      int totalBreadPrice = newBreadOrder.TotalPrice();
      int result = newOrder.BreadTotal;

      //Assert
      Assert.AreEqual(totalBreadPrice, result);
    }

    [TestMethod]
    public void GetPastryTotal_ReturnsTotalPastryPrice_Int()
    {
      //Arrange
      Order newOrder = new Order("1/1/21", 3, 2, 1, 3);
      Pastry newPastryOrder = new Pastry(3);

      //Act
      int totalPastryPrice = newPastryOrder.TotalPrice();
      int result = newOrder.PastryTotal;

      //Assert
      Assert.AreEqual(totalPastryPrice, result);
    }

    [TestMethod]
    public void GetPrice_ReturnsTotalPrice_Int()
    {
      //Arrange
      Order newOrder = new Order("1/1/21", 3, 2, 1, 3);
      Pastry newPastryOrder = new Pastry(3);
      Bread newBreadOrder = new Bread(3, 2, 1);

      //Act
      int totalBreadPrice = newBreadOrder.TotalPrice();
      int totalPastryPrice = newPastryOrder.TotalPrice();
      int totalPrice = totalBreadPrice + totalPastryPrice;
      int result = newOrder.TotalPrice;

      //Assert
      Assert.AreEqual(totalPrice, result);
    }

    [TestMethod]
    public void GetAll_ReturnsEmptyList_OrderList()
    {
      // Arrange
      List<Order> newList = new List<Order> { };

      // Act
      List<Order> result = Order.GetAll();

      // Assert
      CollectionAssert.AreEqual(newList, result);
    }

    [TestMethod]
    public void GetAll_ReturnsOrders_OrderList()
    {
      //Arrange
      Order order1 = new Order("1/1/21", 3, 2, 1, 3);
      Order order2 = new Order("1/2/21", 0, 0, 0, 0);
      List<Order> newList = new List<Order> { order1, order2 };

      //Act
      List<Order> result = Order.GetAll();

      //Assert
      CollectionAssert.AreEqual(newList, result);
    }
  }
}