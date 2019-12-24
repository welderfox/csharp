using System;
using System.Globalization;
using System.Collections.Generic;

namespace Execs
{
  class SomaVetores
  {
    public static void Principal(string[] args)
    {
      int N = int.Parse(Console.ReadLine());

      string[] valoresA = Console.ReadLine().Split(' ');
      string[] valoresB = Console.ReadLine().Split(' ');

      int[] A = new int[N];
      int[] B = new int[N];

      int[] C = new int[N];

      for (int i = 0; i < N; i++)
      {
        A[i] = int.Parse(valoresA[i]);
      }

      for (int i = 0; i < N; i++)
      {
        B[i] = int.Parse(valoresB[i]);
      }

      for (int i = 0; i < N; i++)
      {
        C[i] = A[i] + B[i];
      }

      foreach (var valor in C)
      {
        Console.Write($"{valor} ");
      }
    }
  }
}