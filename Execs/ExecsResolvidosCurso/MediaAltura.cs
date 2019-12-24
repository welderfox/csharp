using System;
using System.Globalization;
using System.Collections.Generic;

namespace Execs
{
  class MediaAltura
  {
    public static void Principal()
    {
      int N = int.Parse(Console.ReadLine());
      string[] nomes = new string[N];
      int[] idades = new int[N];
      double[] alturas = new double[N];


      double soma = 0.0;
      double media = 0.0;
      for (int i = 0; i < N; i++)
      {
        string[] valores = Console.ReadLine().Split(' ');
        nomes[i] = valores[0];
        idades[i] = int.Parse(valores[1]);
        alturas[i] = double.Parse(valores[2], CultureInfo.InvariantCulture);

        soma += alturas[i];
      }

      media = soma / N;
      Console.WriteLine($"Altura média: {media.ToString("F2", CultureInfo.InvariantCulture)}");

      int cont = 0;
      // Percent pessoas menor q 16.
      for (var i = 0; i < N; i++)
      {
        if (idades[i] < 16)
        {
          cont++;
        }
      }

      double percent = (double)cont / N * 100;

      Console.WriteLine($"Pessoas com menos de 16 anos {percent.ToString("F1", CultureInfo.InvariantCulture)}%");
      Console.ReadLine();
    }
  }
}