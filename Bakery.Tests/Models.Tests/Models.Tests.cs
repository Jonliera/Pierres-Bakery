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
    int BreadAmount = 5;
    Bread newBread = new Bread(BreadAmount);
    int result = newBread.BreadAmount;
    Assert.AreEqual(BreadAmount, result);
  }
  
  }
}