/***********************************************************************
 * Module:  Distributor.cs
 * Author:  ya
 * Purpose: Definition of the Class Distributor
 ***********************************************************************/

using System;

public class Distributor
{
   public int buy()
   {
      // TODO: implement
      return 0;
   }
   
   public int sale()
   {
      // TODO: implement
      return 0;
   }
   
   public int add_client()
   {
      // TODO: implement
      return 0;
   }
   
   public int delete_client()
   {
      // TODO: implement
      return 0;
   }
   
   public int add_distributor()
   {
      // TODO: implement
      return 0;
   }
    public Distributor()
    {
        name = "";
        phone = "";
        level=0;
  saled_goods=0;
    clients_number=0;
 goods_number=0;
    profit=0;
        Console.WriteLine("Distributor created (default)");
    }
    public Distributor(string a, string b,int c, int d, int f, int g, float h)
    {
        name = a;
        phone = b;
        level = c;
        saled_goods = d;
        clients_number = f;
        goods_number = g;
        profit = h;
        Console.WriteLine("Distributor created (initialization)");
    }
    public Distributor(Distributor previousDistributor)
    {
        name = previousDistributor.name;
        phone = previousDistributor.phone;
        level = previousDistributor.level;
        saled_goods = previousDistributor.saled_goods;
        clients_number = previousDistributor.clients_number;
        goods_number = previousDistributor.goods_number;
        profit = previousDistributor.profit;
        Console.WriteLine("Distributor created (copy)");
    }

    private string name;
   private int level;
   private int saled_goods;
   private int clients_number;
   private string phone;
   private int goods_number;
   private float profit;

}