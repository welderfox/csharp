using System;
using System.Globalization;
using System.Collections.Generic;

namespace Execs
{
  class NotasMedias
  {
    public static void Principal()
    {
      int n = int.Parse(Console.ReadLine());

      string[] nomes = new string[n];

      double[] nota1 = new double[n];

      double[] nota2 = new double[n];

      for (int i = 0; i < n; i++)
      {
        string[] valores = Console.ReadLine().Split(' ');
        nomes[i] = valores[0];
        nota1[i] = double.Parse(valores[1], CultureInfo.InvariantCulture);
        nota2[i] = double.Parse(valores[2], CultureInfo.InvariantCulture);
      }

      Console.WriteLine("Alunos aprovados:");
      for (int i = 0; i < n; i++)
      {
        var media = 0.0;
        media = (nota1[i] + nota2[i]) / 2;
        if (media >= 6.0)
        {
          Console.WriteLine(nomes[i]);
        }
      }
    }
  }
}