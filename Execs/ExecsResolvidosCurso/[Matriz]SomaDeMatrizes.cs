using System;
using System.Globalization;
using System.Collections.Generic;

namespace Execs
{
  class SomaDeMatrizes
  {
    public static void Principal()
    {
      string[] vet = Console.ReadLine().Split(' ');

      int m = int.Parse(vet[0]);
      int n = int.Parse(vet[1]);

      int[,] matA = new int[m, n];
      int[,] matB = new int[m, n];
      int[,] matC = new int[m, n];

      for (int i = 0; i < m; i++)
      {
        string[] valores = Console.ReadLine().Split(' ');
        for (int j = 0; j < n; j++)
        {
          matA[i, j] = int.Parse(valores[j]);
        }
      }

      for (int i = 0; i < m; i++)
      {
        string[] valores = Console.ReadLine().Split(' ');
        for (int j = 0; j < n; j++)
        {
          matB[i, j] = int.Parse(valores[j]);
        }
      }

      for (int i = 0; i < m; i++)
      {
        for (int j = 0; j < n; j++)
        {
          matC[i, j] = matA[i, j] + matB[i, j];
        }
      }

      for (int i = 0; i < m; i++)
      {
        for (int j = 0; j < n; j++)
        {
          Console.Write(matC[i, j] + " ");
        }
        Console.WriteLine();
      }
    }
  }
}