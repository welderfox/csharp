using System;
using System.Globalization;
using System.Collections.Generic;

namespace Execs
{
  class PessoaMaisVelha
  {
    public static void Principal()
    {
      int N = int.Parse(Console.ReadLine());

      string[] nomes = new string[N];
      int[] idades = new int[N];


      // string[] valoresIdades = Console.ReadLine().Split(' ');

      for (int i = 0; i < N; i++)
      {
        string[] valores = Console.ReadLine().Split(' ');
        nomes[i] = valores[0];
        idades[i] = int.Parse(valores[1]);
      }

      int pos = 0;

      for (int i = 0; i < N; i++)
      {
        if (i != 0)
        {
          if (idades[i] > idades[i - 1])
          {
            pos = i;
          }
        }
        else
        {
          pos = i;
        }
      }
      Console.WriteLine($"Pessoa mais velha: {nomes[pos]}");
    }
  }
}