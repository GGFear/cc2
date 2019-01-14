/***********************************************************************
 * Module:  Product.cs
 * Author:  ya
 * Purpose: Definition of the Class Product
 ***********************************************************************/

using System;

public class Product
{
    public Product()
    {
        name = "";
        price = 0;
        index = 0;
        dimensions = "";
        availability =false;
        number = 0;
        Console.WriteLine("Product created (default)");
    }
    public Product(string a, float b, int c, string d, bool f, int g)
    {
        name = a;
        price = b;
        index = c;
       dimensions = d;
        availability = f;
        number = g;
  
        Console.WriteLine("Product created (initialization)");
    }
    public Product(Product previousProduct)
    {
        name = previousProduct.name;
        price = previousProduct.price;
        index = previousProduct.index;
        dimensions = previousProduct.dimensions;
        availability = previousProduct.availability;
        number = previousProduct.number;
        Console.WriteLine("Product created (copy)");
    }

    private string name;
   private float price;
   private int index;
   private string dimensions;
   private bool availability;
   private int number;

}