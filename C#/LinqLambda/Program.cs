using System;
using System.Collections.Generic;
using System.Linq;

namespace LinqLambda
{
  class Program
  {
    static void Print<T>(string message, IEnumerable<T> collection)
    {
      Console.WriteLine(message);
      foreach (T obj in collection)
      {
        Console.WriteLine(obj);
      }
      Console.WriteLine();
    }

    static void Main(string[] args)
    {
      Category c1 = new Category() { Id = 1, Name = "Tools", Tier = 2 };
      Category c2 = new Category() { Id = 2, Name = "Computers", Tier = 1 };
      Category c3 = new Category() { Id = 3, Name = "Electronics", Tier = 1 };

      List<Product> products = new List<Product>() {
          new Product() { Id = 1, Name = "Computer", Price = 1100.0, Category = c2 },
          new Product() { Id = 2, Name = "Hammer", Price = 90.0, Category = c1 },
          new Product() { Id = 3, Name = "Tv", Price = 1700.0, Category = c3 },
          new Product() { Id = 4, Name = "Notebook", Price = 1300.0, Category = c2 },
          new Product() { Id = 5, Name = "Saw", Price = 80.0, Category = c1 },
          new Product() { Id = 6, Name = "Tablet", Price = 700.0, Category = c2 },
          new Product() { Id = 7, Name = "Camera", Price = 700.0, Category = c3 },
          new Product() { Id = 8, Name = "Printer", Price = 350.0, Category = c3 },
          new Product() { Id = 9, Name = "MacBook", Price = 1800.0, Category = c2 },
          new Product() { Id = 10, Name = "Sound Bar", Price = 700.0, Category = c3 },
          new Product() { Id = 11, Name = "Level", Price = 70.0, Category = c1 }
      };

      // var resultado1 = products.Where(product => product.Category.Tier == 1 && product.Price < 900);
      var resultado1 =
        from product in products
        where product.Category.Tier == 1 && product.Price < 900.0
        select product;
      ;
      // var resultado2 = products.Where(product => product.Category.Name == "Tools").Select(product => product.Name);
      var resultado2 =
        from product in products
        where product.Category.Name == "Tools"
        select product;
      ;
      // var resultado3 = products.Where(product => product.Name[0] == 'C')
      //                 //    .Select(product => product.Name + ' ' + product.Price + ' ' + product.Category.Name); ouuu
      //                 .Select(product => new
      //                 {
      //                   ProductName = product.Name,
      //                   product.Price,
      //                   CategoryName = product.Category.Name
      //                 });
      var resultado3 =
          from product in products
          where product.Name[0] == 'C'
          select new
          {
            product.Name,
            product.Price,
            CategoryName = product.Category.Name
          };
      // var resultado4 = products.Where(product => product.Category.Tier == 1)
      // .OrderBy(product => product.Price).ThenBy(product => product.Name);
      var resultado4 =
          from product in products
          where product.Category.Tier == 1
          orderby product.Name
          orderby product.Price
          select product;


      // var resultado5 = resultado4.Skip(2).Take(4);
      var resultado5 =
          (from product in resultado4
           select product).Skip(2).Take(4);
      var resultado6 = products.First();

      var resultado7 = products.Where(product => product.Price > 3000.0).FirstOrDefault();

      var resultado8 = products.Where(product => product.Id == 3).SingleOrDefault();

      var resultado9 = products.Max(product => product.Price);

      var resultado10 = products.Min(product => product.Price);

      var resultado11 = products.Where(product => product.Category.Id == 1).Sum(product => product.Price);

      var resultado12 = products.Where(product => product.Category.Id == 1).Average(product => product.Price);

      var resultado13 = products.Where(product => product.Category.Id == 5).Select(product => product.Price)
                        .DefaultIfEmpty(0.0).Average();
      var resultado14 = products.Where(product => product.Category.Id == 5).Select(product => product.Price)
                        .Aggregate(0.0, (prevProduct, nextProduct) => prevProduct + nextProduct);
      // var resultado15 = products.GroupBy(product => product.Category);
      var resultado15 =
          from product in products
          group product by product.Category;

      // Print("resultado15:", resultado15);
      foreach (IGrouping<Category, Product> group in resultado15)
      {
        Console.WriteLine();
        Console.WriteLine("Categoria " + group.Key.Name + ":");
        foreach (Product product in group)
        {
          Console.WriteLine(product);
        }
        Console.WriteLine();
      }

      //   Print("Products from tools:", resultado5);
      // Console.WriteLine("Max Price: " + resultado9);
      // Console.WriteLine("Min Price: " + resultado10);
      // Console.WriteLine("Sun Prices Cat1: " + resultado11);
      // Console.WriteLine("Average Prices Cat1: " + resultado12);
      // Console.WriteLine("Average default 0 Prices Cat1: " + resultado13);
      // Console.WriteLine("Aggregate Prices Cat1: " + resultado14);
      Console.WriteLine("GroupBy Cat: " + resultado15);

    }
  }
}
