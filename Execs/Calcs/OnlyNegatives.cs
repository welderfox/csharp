using System;
using System.Globalization;
using System.Collections.Generic;

namespace Execs
{
  class OnlyNegatives
  {
    public static void Principal()
    {
      int N;

      int[] vet;
      N = int.Parse(Console.ReadLine());

      vet = new int[N];

      string[] valores = Console.ReadLine().Split(' ');

      for (int i = 0; i < N; i++)
      {
        vet[i] = int.Parse(valores[i]);
      }

      for (int i = 0; i < N; i++)
      {
        if (vet[i] < 0)
        {
          Console.WriteLine(vet[i]);
        }
      }
    }
  }
}