using System;
using System.Globalization;
using System.Collections.Generic;

namespace Execs
{
  class MediaVetor
  {
    public static void Principal()
    {
      int N = int.Parse(Console.ReadLine());

      double[] vet = new double[N];
      string[] valores = Console.ReadLine().Split(' ');

      double soma = 0;
      for (int i = 0; i < N; i++)
      {
        vet[i] = double.Parse(valores[i], CultureInfo.InvariantCulture);
        soma = soma + vet[i];
      }

      for (int i = 0; i < N; i++)
      {
        Console.Write($"{vet[i].ToString("F1", CultureInfo.InvariantCulture)} ");
      }
      Console.WriteLine();
      Console.WriteLine(soma.ToString("F2", CultureInfo.InvariantCulture));
      Console.WriteLine((soma / N).ToString("F2", CultureInfo.InvariantCulture));
    }
  }
}