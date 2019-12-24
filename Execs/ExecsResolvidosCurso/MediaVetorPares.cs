using System;
using System.Globalization;
using System.Collections.Generic;

namespace Execs
{
  class MediaVetorPares
  {
    public static void Principal()
    {
      int N = int.Parse(Console.ReadLine());

      int[] numeros = new int[N];

      string[] valores = Console.ReadLine().Split(' ');

      for (int i = 0; i < N; i++)
      {
        numeros[i] = int.Parse(valores[i]);
      }
      int soma = 0;
      double media = 0.0;
      int count = 0;

      foreach (var numero in numeros)
      {
        if (numero % 2 == 0)
        {
          count++;
          soma += numero;
        }
      }

      media = soma / count;
      Console.WriteLine(media.ToString("F1", CultureInfo.InvariantCulture));
    }
  }
}