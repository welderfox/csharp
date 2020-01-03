using System;
using System.Globalization;
using System.Collections.Generic;

namespace Execs
{
  class MatrizQuadrada
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

      int countNegativo = 0;
      for (int i = 0; i < n; i++)
      {
        for (int j = 0; j < n; j++)
        {
          if (matriz[i, j] < 0)
          {
            countNegativo++;
          }
        }
      }

      Console.WriteLine("DIAGONAL PRINCIPAL:");
      for (int i = 0; i < n; i++)
      {
        Console.Write(matriz[i, i] + " ");
      }

      Console.WriteLine();
      Console.WriteLine($"QUANTIDADE DE NEGATIVOS = {countNegativo}");
    }
  }
}