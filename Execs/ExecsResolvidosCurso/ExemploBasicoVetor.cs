using System;
using System.Globalization;
using System.Collections.Generic;

namespace Execs
{
  class ExemploBasicoVetor
  {
    public static void Exemplo()
    {
      int N;
      N = int.Parse(Console.ReadLine());
      double[] vet = new double[N];

      for (int i = 0; i < N; i++)
      {
        vet[i] = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
      }

      double soma = 0.0;
      for (int i = 0; i < N; i++)
      {
        soma += vet[i];
      }

      double avg = soma / N;

      Console.WriteLine("AVERAGE HEIGHT = " + avg.ToString("F2", CultureInfo.InvariantCulture));
    }
  }
}