using System;
using System.Globalization;
using System.Collections.Generic;

namespace Execs
{
  class ProdutosELucro
  {
    public static void Proncipal()
    {
      int n = int.Parse(Console.ReadLine());

      string[] produtos = new string[n];

      double[] precoCompra = new double[n];

      double[] precoVenda = new double[n];

      double somaCompra = 0.0;
      double somaVenda = 0.0;
      for (int i = 0; i < n; i++)
      {
        string[] valores = Console.ReadLine().Split(' ');
        produtos[i] = valores[0];
        precoCompra[i] = double.Parse(valores[1], CultureInfo.InvariantCulture);
        precoVenda[i] = double.Parse(valores[2], CultureInfo.InvariantCulture);
        somaCompra += precoCompra[i];
        somaVenda += precoVenda[i];
      }

      int count10 = 0;
      int count1020 = 0;
      int count20 = 0;

      for (int i = 0; i < n; i++)
      {
        double percent = precoCompra[i] * 0.1;
        double lucro = precoVenda[i] - precoCompra[i];
        if (lucro < percent)
        {
          count10++;
        }
        else if (lucro >= percent && lucro <= (percent * 2.0))
        {
          count1020++;
        }
        else
        {
          count20++;
        }
      }

      double lucroTotal = somaVenda - somaCompra;

      Console.WriteLine($"Lucro abaixo de 10%: {count10}");
      Console.WriteLine($"Lucro entre 10% e 20%: {count1020}");
      Console.WriteLine($"Lucro acima de 20%: {count20}");
      Console.WriteLine($"Valor total de compra: {somaCompra.ToString("F2", CultureInfo.InvariantCulture)}");
      Console.WriteLine($"Valor total de venda: {somaVenda.ToString("F2", CultureInfo.InvariantCulture)}");
      Console.WriteLine($"Lucro total: {lucroTotal.ToString("F2", CultureInfo.InvariantCulture)}");
    }
  }
}