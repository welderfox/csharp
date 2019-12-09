using System;
using System.IO;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;

namespace produto_estoque
{
  class LerArquivoProduct
  {
    static void LerArquivoDeProduto()
    {
      Console.Write("Digite o caminho do arquivo: ");
      string path = Console.ReadLine();

      List<Produto> list = new List<Produto>();

      using (StreamReader sr = File.OpenText(path))
      {
        while (!sr.EndOfStream)
        {
          string[] fields = sr.ReadLine().Split(',');

          string name = fields[0];
          double price = double.Parse(fields[1], CultureInfo.InvariantCulture);
          list.Add(new Produto(name, price));
        }
      }

      var media = list.Select(product => product.Preco).DefaultIfEmpty(0.0).Average();

      Console.Write("Average Preco = " + media.ToString("F2", CultureInfo.InvariantCulture));

      var abaixoDamedia = list.Where(product => product.Preco < media)
      .OrderByDescending(product => product.Nome).Select(product => product.Nome);
      Console.WriteLine();
      foreach (string name in abaixoDamedia)
      {
        Console.WriteLine(name);
      }
    }
  }
}