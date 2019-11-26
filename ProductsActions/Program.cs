using System;
using System.Collections.Generic;
using System.Linq;

namespace ProductsActions
{
  class Program
  {
    static void Main(string[] args)
    {
      List<Product> list = new List<Product>();
      list.Add(new Product("TV", 900.00));
      list.Add(new Product("Mouse", 50.00));
      list.Add(new Product("Tablet", 350.50));
      list.Add(new Product("HD Case", 80.90));

      Action<Product> act = UpdatePrice;

      Func<Product, string> func = p => p.Name.ToUpper();

      //   list.ForEach(act); ouuuu
      List<String> result = list.Select(func).ToList();
      result.ForEach(ShowUpper);
    }

    static void UpdatePrice(Product p)
    {
      p.Price += p.Price * 0.1;
    }
    static void ShowProduct(Product p)
    {
      Console.WriteLine(p);
    }
    static void ShowUpper(string r)
    {
      Console.WriteLine(r);
    }
  }
}
