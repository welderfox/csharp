using System;
using System.Globalization;
using System.Collections.Generic;

namespace Execs
{
  class OutroExemploVetorComClasses
  {
    public static void Pincipal()
    {
      int n = int.Parse(Console.ReadLine());

      Product[] produtos = new Product[n];

      for (int i = 0; i < n; i++)
      {
        string name = Console.ReadLine();
        double preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        produtos[i] = new Product { Name = name, Price = preco };
      }

      double soma = 0.0;

      for (int i = 0; i < n; i++)
      {
        soma += produtos[i].Price;
      }

      double media = soma / n;

      Console.WriteLine("AVERAGE PRICE = " + media.ToString("F2", CultureInfo.InvariantCulture));
    }
  }
}