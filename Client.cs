/***********************************************************************
 * Module:  Client.cs
 * Author:  ya
 * Purpose: Definition of the Class Client
 ***********************************************************************/

using System;

public class Client
{
   public int buy()
   {
      // TODO: implement
      return 0;
   }

   public static string name;
   public static string phone;
    private Client()
    {
        //name = "";
        //phone = "";
        Console.WriteLine("Client created (default)");
    }
    public Client(string s, string b)
    {
        name = s;
        phone = b;
        Console.WriteLine("Client created (initialization)");
    }
 /*   public Client(Client previousClient)
    {
        name = previousClient.name;
        phone = previousClient.phone;
        Console.WriteLine("Client created (copy)");
    }*/
}