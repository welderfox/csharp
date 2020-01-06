using System;
using System.Globalization;
using System.Collections.Generic;

namespace Execs
{
  class MatrizSoma
  {
    public static void Principal()
    {
      string[] vet = Console.ReadLine().Split(' ');
      int m = int.Parse(vet[0]);
      int n = int.Parse(vet[1]);

      int[,] matriz = new int[m, n];

      for (int i = 0; i < m; i++)
      {
        string[] valores = Console.ReadLine().Split(' ');
        for (int j = 0; j < n; j++)
        {
          matriz[i, j] = int.Parse(valores[j]);
        }
      }

      int[] somas = new int[m];
      for (int i = 0; i < m; i++)
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