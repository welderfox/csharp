using System;
using System.Globalization;
using System.Collections.Generic;

namespace Execs
{
  class SomaLinhasMatriz
  {
    public static void Principal()
    {
      int n = int.Parse(Console.ReadLine());

      int[,] matriz = new int[n, n];

      for (int i = 0; i < n; i++)
      {
        string[] valores = Console.ReadLine().Split(' ');
        for (int j = 0; j < n; j++)
        {
          matriz[i, j] = int.Parse(valores[j]);
        }
      }


      int[] somas = new int[n];
      for (int i = 0; i < n; i++)
      {
        for (int j = 0; j < n; j++)
        {
          somas[i] += matriz[i, j];
        }
      }

      foreach (var item in somas)
      {
        Console.WriteLine(item);
      }
    }
  }
}