/***********************************************************************
 * Module:  Company.cs
 * Author:  ya
 * Purpose: Definition of the Class Company
 ***********************************************************************/

using System;

public class Company
{

   public void add_distr()
   {
      // TODO: implement
   }
   
   public void delete_distr()
   {
      // TODO: implement
   }
   
   public int make_product()
   {
      // TODO: implement
      return 0;
   }

   public Plan plan;
   public System.Collections.ArrayList distributor;
   
   /// <pdGenerated>default getter</pdGenerated>
   public System.Collections.ArrayList GetDistributor()
   {
      if (distributor == null)
         distributor = new System.Collections.ArrayList();
      return distributor;
   }
   
   /// <pdGenerated>default setter</pdGenerated>
   public void SetDistributor(System.Collections.ArrayList newDistributor)
   {
      RemoveAllDistributor();
      foreach (Distributor oDistributor in newDistributor)
         AddDistributor(oDistributor);
   }
   
   /// <pdGenerated>default Add</pdGenerated>
   public void AddDistributor(Distributor newDistributor)
   {
      if (newDistributor == null)
         return;
      if (this.distributor == null)
         this.distributor = new System.Collections.ArrayList();
      if (!this.distributor.Contains(newDistributor))
         this.distributor.Add(newDistributor);
   }
   
   /// <pdGenerated>default Remove</pdGenerated>
   public void RemoveDistributor(Distributor oldDistributor)
   {
      if (oldDistributor == null)
         return;
      if (this.distributor != null)
         if (this.distributor.Contains(oldDistributor))
            this.distributor.Remove(oldDistributor);
   }
   
   /// <pdGenerated>default removeAll</pdGenerated>
   public void RemoveAllDistributor()
   {
      if (distributor != null)
         distributor.Clear();
   }


   public System.Collections.ArrayList product;
   
   /// <pdGenerated>default getter</pdGenerated>
   public System.Collections.ArrayList GetProduct()
   {
      if (product == null)
         product = new System.Collections.ArrayList();
      return product;
   }
   
   /// <pdGenerated>default setter</pdGenerated>
   public void SetProduct(System.Collections.ArrayList newProduct)
   {
      RemoveAllProduct();
      foreach (Product oProduct in newProduct)
         AddProduct(oProduct);
   }
   
   /// <pdGenerated>default Add</pdGenerated>
   public void AddProduct(Product newProduct)
   {
      if (newProduct == null)
         return;
      if (this.product == null)
         this.product = new System.Collections.ArrayList();
      if (!this.product.Contains(newProduct))
         this.product.Add(newProduct);
   }
   
   /// <pdGenerated>default Remove</pdGenerated>
   public void RemoveProduct(Product oldProduct)
   {
      if (oldProduct == null)
         return;
      if (this.product != null)
         if (this.product.Contains(oldProduct))
            this.product.Remove(oldProduct);
   }
   
   /// <pdGenerated>default removeAll</pdGenerated>
   public void RemoveAllProduct()
   {
      if (product != null)
         product.Clear();
   }
    public Company()
    {
        name = "";
        distributor_number=0;
    goods_number=0;
     goods_price=0;
     mlm_level=1;
    Product product= new Product();
        plan = new Plan();
   Distributor distributor = new Distributor();
        Console.WriteLine("Company created (default)");

    }
    public Company(string a, int b, int c, float d, int e)
    {
        name = a;
        distributor_number = b;
        goods_number = c;
        goods_price =d;
       mlm_level = e;
      Product product2 = new Product("", 0, 0,"", false, 0);
        plan = new Plan(0,0,0,0);
     Distributor distributor2 = new Distributor("","", 0, 0, 0, 0, 0);
        Console.WriteLine("Company created (initialization)");
    }

    public Company(Company previousCompany)
    {
        Product product3 = new Product();
        Product product4 = new Product(product3);
        Distributor distributor3 = new Distributor();
        Distributor distributor4 = new Distributor(distributor3);
       Plan plan = new Plan();
       Plan plan2 = new Plan(plan);
        name = previousCompany.name;
        distributor_number = previousCompany.distributor_number;
        goods_number = previousCompany.goods_number;
        goods_price = previousCompany.goods_price;
        mlm_level = previousCompany.mlm_level;
        Console.WriteLine("Company created (copy)");
    }

    private int distributor_number;
   private int goods_number;
   private float goods_price;
   private int mlm_level;
   private string name;

}