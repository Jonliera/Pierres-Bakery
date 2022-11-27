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
  public int PastryCost()
  {
  int pastryCost = 0;
  int pastryTotal = PastryAmount;
  int remainder =  pastryTotal % 3;
  if (pastryTotal > 2 )
  {
  pastryCost = (((pastryTotal - remainder) / 3 * 5 ) * 2);
  }
  else
  {
  pastryCost = pastryTotal * 2;
  }
  return pastryCost;
  }
  }
  }

   
