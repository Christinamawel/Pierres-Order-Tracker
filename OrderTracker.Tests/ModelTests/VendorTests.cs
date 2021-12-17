using Microsoft.VisualStudio.TestTools.UnitTesting;
using OrderTracker.Models;
using System.Collections.Generic;
using System;

namespace OrderTracker.Tests
{
  [TestClass]
  public class VendorTests :IDisposable
  {
    public void Dispose()
    {
      Vendor.ClearAll();
    }

    [TestMethod]
    public void VendorConstructor_CreatesInstanceOfVendor_Vendor()
    {
      Vendor newVendor = new Vendor("testVendor");
      Assert.AreEqual(typeof(Vendor), newVendor.GetType());
    }

    [TestMethod]
    public void GetName_ReturnsName_String()
    {
    //Arrange
    string name = "Test Vendor";
    Vendor newVendor = new Vendor(name);

    //Act
    string result = newVendor.Name;

    //Assert
    Assert.AreEqual(name, result);
    }

    [TestMethod]
    public void GetId_ReturnsVendorId_Int()
    {
    //Arrange
    Vendor newVendor = new Vendor("test");

    //Act
    int result = newVendor.Id;

    //Assert
    Assert.AreEqual(0, result);
    }

    [TestMethod]
    public void GetAll_ReturnsAllVendorObjects_VendorList()
    {
    //Arrange
    string name01 = "test";
    string name02 = "test1";
    Vendor newVendor1 = new Vendor(name01);
    Vendor newVendor2 = new Vendor(name02);
    List<Vendor> newList = new List<Vendor> { newVendor1, newVendor2 };

    //Act
    List<Vendor> result = Vendor.GetAll();

    //Assert
    CollectionAssert.AreEqual(newList, result);
    }

    [TestMethod]
    public void Find_ReturnsCorrectVendor_Vendor()
    {
    //Arrange
    string name01 = "test";
    string name02 = "test1";
    Vendor newVendor1 = new Vendor(name01);
    Vendor newVendor2 = new Vendor(name02);

    //Act
    Vendor result = Vendor.Find(1);

    //Assert
    Assert.AreEqual(newVendor2, result);
    }

    [TestMethod]
    public void AddItem_AssociatesOrderWithVendor_OrderList()
    {
    //Arrange
    Order newOrder = new Order("1/1/21", 3, 2, 1, 3);
    List<Order> newList = new List<Order> { newOrder };
    string name = "test";
    Vendor newVendor = new Vendor(name);
    newVendor.AddOrder(newOrder);

    //Act
    List<Order> result = newVendor.Orders;

    //Assert
    CollectionAssert.AreEqual(newList, result);
    }
  }
}