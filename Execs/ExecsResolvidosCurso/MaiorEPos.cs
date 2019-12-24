using System;
using System.Globalization;
using System.Collections.Generic;

namespace Execs
{
  class MaiorEPos
  {
    public static void Principal()
    {
      int N = int.Parse(Console.ReadLine());

      double[] numeros = new double[N];
      string[] valores = Console.ReadLine().Split(' ');

      for (int i = 0; i < N; i++)
      {
        numeros[i] = double.Parse(valores[i], CultureInfo.InvariantCulture);
      }

      double maior = 0.0;
      int pos = 0;

      for (int i = 0; i < N; i++)
      {
        if (i != 0)
        {
          if (numeros[i] > numeros[i - 1])
          {
            maior = numeros[i];
            pos = i;
          }
        }
        else
        {
          maior = numeros[i];
          pos = i;
        }
      }

      Console.WriteLine(maior.ToString("F1", CultureInfo.InvariantCulture));
      Console.WriteLine(pos);
    }
  }
}