using System;
using System.Globalization;
using System.Collections.Generic;

namespace Execs
{
  class ForEach
  {
    public static void Principal()
    {
      int N;
      N = int.Parse(Console.ReadLine());
      string[] nomes = new string[N];

      for (int i = 0; i < N; i++)
      {
        nomes[i] = Console.ReadLine();
      }

      Console.WriteLine("Nomes lidos:");
      foreach (var nome in nomes)
      {
        Console.WriteLine(nome);
      }
    }
  }
}