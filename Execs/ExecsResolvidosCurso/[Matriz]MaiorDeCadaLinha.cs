using System;
using System.Globalization;
using System.Collections.Generic;

namespace Execs
{
  class MaiorDeCadaLinha
  {
    public static void Principal()
    {
      int N = int.Parse(Console.ReadLine());

      int[,] matriz = new int[N, N];

      for (int i = 0; i < N; i++)
      {
        string[] valores = Console.ReadLine().Split(' ');
        for (int j = 0; j < N; j++)
        {
          matriz[i, j] = int.Parse(valores[j]);
        }
      }

      int[] maiores = new int[N];
      for (int i = 0; i < N; i++)
      {
        for (int j = 0; j < N; j++)
        {
          if (j > 0)
          {
            if (maiores[i] < matriz[i, j])
            {
              maiores[i] = matriz[i, j];
            }
          }
          else
          {
            maiores[i] = matriz[i, j];
          }
        }
      }

      foreach (var item in maiores)
      {
        Console.WriteLine(item);
      }
    }
  }
}