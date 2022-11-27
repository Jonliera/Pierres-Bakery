using System;
using Bakery.Models;

namespace Bakery.Models
{
  public class Program
  {
    public static void Main()
    {
      Console.WriteLine("Hello! Welcome to Pierres Bakery");
      Console.WriteLine("--------------------------------");
      Console.WriteLine("We offer the following products");
      Console.WriteLine("Bread: $5 (Buy 2, Get the 3rd one for Free!!!)");
      Console.WriteLine("--------------------------------");
      Console.WriteLine("Pastries: $2 (Buy 2, Get the 3rd for $1 extra");
      Console.WriteLine("--------------------------------");
      Console.WriteLine("How many loaves of Bread would you like to order( Enter Amount)?");
      int breadAmount = int.Parse(Console.ReadLine());
      Bread buyBread = new Bread(breadAmount);
      Console.WriteLine("Your bread total comes to $" + buyBread.BreadCost());
      Console.WriteLine("--------------------------------");
      Console.WriteLine("How many pieces of pastries would you like to order( Enter Amount)?");
      int pastryAmount = int.Parse(Console.ReadLine());
      Pastry buyPastry = new Pastry(pastryAmount);
      Console.WriteLine("Your Pastry total comes to $" + buyPastry.PastryCost());
      Console.WriteLine("--------------------------------");
      int total = buyBread.BreadCost() + buyPastry.PastryCost();
      Console.WriteLine("Your Total is :$" + total);
      Console.WriteLine("Thank you for your ourder");
    }
  }
}