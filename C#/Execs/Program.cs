using System;
using System.Globalization;

namespace Execs
{
  class Program
  {

    public static void Main(string[] args)
    {
      Product p = new Product();

      Console.WriteLine("Entre os dados do produto: ");
      Console.Write("Nome: ");
      p.Nome = Console.ReadLine();
      Console.Write("Preço: ");
      p.Preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
      Console.Write("Quantidade no estoque: ");
      p.Quantidade = int.Parse(Console.ReadLine());
    }
  }
}
