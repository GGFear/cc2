/***********************************************************************
 * Module:  Plan.cs
 * Author:  ya
 * Purpose: Definition of the Class Plan
 ***********************************************************************/

using System;

public class Plan
{
   public bool work_out()
   {
      // TODO: implement
      return false;
   }
    public Plan()
    {
        term=0;
  planned_number=0;
  sold_number=0;
     sold_value=0;
    Console.WriteLine("Plan created (default)");
    }
    public Plan(int a, int b, int c, int d)
    {
        term = a;
        planned_number = b;
        sold_number = c;
        sold_value = d;
        Console.WriteLine("Plan created (initialization)");
    }

    public Plan(Plan previousPlan)
    {
  
   
        planned_number = previousPlan.planned_number;
        sold_number = previousPlan.sold_number;
        sold_value = previousPlan.sold_value;
        Console.WriteLine("Plan created (copy)");
    }
    static Plan()
    {
        term = 30;
        Console.WriteLine("Static constructor sets Plan's term to 30");
    }
    static int term;
   private int planned_number;
   private int sold_number;
   private int sold_value;

}