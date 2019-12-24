using System;
using System.Globalization;
using System.Collections.Generic;

namespace Execs
{
  class MediasVetor
  {
    public static void Principal()
    {
      int N = int.Parse(Console.ReadLine());

      double[] numeros = new double[N];

      string[] valores = Console.ReadLine().Split(' ');

      double soma = 0.0;
      double media = 0.0;
      for (int i = 0; i < N; i++)
      {
        numeros[i] = double.Parse(valores[i], CultureInfo.InvariantCulture);
        soma += numeros[i];
      }

      media = soma / N;
      Console.WriteLine(media.ToString("F3", CultureInfo.InvariantCulture));
      foreach (var numero in numeros)
      {
        if (numero < media)
        {
          Console.WriteLine(numero.ToString("F1", CultureInfo.InvariantCulture));
        }
      }
    }
  }
}