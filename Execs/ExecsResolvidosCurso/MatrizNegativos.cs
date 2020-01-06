using System;
using System.Globalization;
using System.Collections.Generic;

namespace Execs
{
  class MatrizNegativos
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

      Console.WriteLine("VALORES NEGATIVOS:");
      for (int i = 0; i < m; i++)
      {
        for (int j = 0; j < n; j++)
        {
          if (matriz[i, j] < 0)
          {
            Console.WriteLine(matriz[i, j]);
          }
        }
      }
    }
  }
}