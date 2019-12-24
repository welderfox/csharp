using System;
using System.Globalization;
using System.Collections.Generic;

namespace Execs
{
  class CountPares
  {
    public static void Principal()
    {
      int N = int.Parse(Console.ReadLine());

      int[] numeros = new int[N];


      string[] valores = Console.ReadLine().Split(' ');

      for (int i = 0; i < N; i++)
      {
        numeros[i] = int.Parse(valores[i]);
      }

      int count = 0;
      for (int i = 0; i < N; i++)
      {
        if (numeros[i] % 2 == 0)
        {
          count++;
          Console.Write($"{numeros[i]} ");
        }
      }
      Console.WriteLine();
      Console.WriteLine(count);
    }
  }
}