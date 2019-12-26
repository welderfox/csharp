using System;
using System.Globalization;
using System.Collections.Generic;

namespace Execs
{
  class MediaAlturaMascFem
  {
    public static void Principal()
    {
      int n = int.Parse(Console.ReadLine());

      double[] alturas = new double[n];

      char[] sexos = new char[n];

      double soma = 0.0;
      int count = 0;
      for (int i = 0; i < n; i++)
      {
        string[] valores = Console.ReadLine().Split(' ');
        alturas[i] = double.Parse(valores[0], CultureInfo.InvariantCulture);
        sexos[i] = char.Parse(valores[1]);
        if (sexos[i] == 'F')
        {
          soma += alturas[i];
        }
        else
        {
          count++;
        }
      }

      double maior = 0.0;
      double menor = 0.0;
      for (int i = 0; i < n; i++)
      {
        if (alturas.Length == 0)
        {
          maior = alturas[i];
          menor = alturas[i];
          break;
        }

        if (i > 0)
        {
          if (alturas[i - 1] > alturas[i])
          {
            maior = alturas[i - 1];
          }

          if (alturas[i] < alturas[i - 1])
          {
            menor = alturas[i];
          }
        }
      }

      double media = soma / (n - count);
      Console.WriteLine($"Menor altura = {menor.ToString("F2", CultureInfo.InvariantCulture)}");
      Console.WriteLine($"Maior altura = {maior.ToString("F2", CultureInfo.InvariantCulture)}");
      Console.WriteLine($"Media das alturas das mulheres = {media.ToString("F2", CultureInfo.InvariantCulture)}");
      Console.WriteLine($"Número de homens = {count}");
    }
  }
}