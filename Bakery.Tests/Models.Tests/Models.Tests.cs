using Microsoft.VisualStudio.TestTools.UnitTesting;
using Bakery.Models;
using System;

namespace Bakery.Tests
{
  [TestClass]
  public class BreadTests
  {
  [TestMethod]
    public void BreadConstructor_CreatesInstanceOfBread_Bread()
    {
      Bread newBread = new Bread(3);
      Assert.AreEqual(typeof(Bread), newBread.GetType());
    } 
  [TestMethod]
  public void GetAmount_ReturnAmount_Int()
  {
    int numberBread = 5;
    Bread newBread = new Bread(numberBread);
    int result = newBread.BreadAmount;
    Assert.AreEqual(numberBread, result);
  }
  [TestMethod]
  public void BreadCost_ReturnCostOrder_int()
  {
    int totalCost = 5;
    int numberBread = 1;
    Bread newBread = new Bread(numberBread);
    int result = newBread.BreadCost();
    Assert.AreEqual(totalCost, result);
  } 
  }
} 