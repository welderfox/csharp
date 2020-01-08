using System;
using System.Globalization;
using System.Collections.Generic;

namespace Execs
{
  class MatrizAcimaDaDiagonal
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

      int soma = 0;
      for (int i = 0; i < n; i++)
      {
        if (i < n - 1)
        {
          for (int j = i + 1; j < n; j++)
          {
            soma += matriz[i, j];
          }
        }
      }

      Console.WriteLine(soma);
    }
  }
}