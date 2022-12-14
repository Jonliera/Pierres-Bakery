using System;
using System.Collections.Generic;

namespace Bakery.Models
{
  public class Bread
  {
   public int BreadAmount { get; set;}
   public Bread (int breadAmount)
   {
    BreadAmount = breadAmount;
   }
  public int BreadCost()
  {
  int breadCost = 0;
  int breadTotal = BreadAmount;
  if (breadTotal >= 3)
  {
  breadCost = (breadTotal * 5) - ((breadTotal / 3) *5 );
  }
  else
  {
  breadCost = breadTotal * 5;
  }
  return breadCost;
  }
  }
  public class Pastry
   {
  public int PastryAmount { get; set;}
  public Pastry (int pastryAmount)
   {
     PastryAmount = pastryAmount;
   }
  public int PastryTotalCost()
  {
  int pastryCost = 2;
  int discountCost = pastryCost / 2;
  int discount = PastryAmount / 3 * discountCost;
  return PastryAmount * pastryCost - discount;
    }
}
}
  
  