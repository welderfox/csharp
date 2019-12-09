using System;
using System.Globalization;

namespace Execs
{
  class Uri1071
  {
    public static void Intervalo()
    {
      int x, y, soma = 0;
      x = int.Parse(Console.ReadLine());
      y = int.Parse(Console.ReadLine());

      if (x > y)
      {
        for (var i = y + 1; i < x; i++)
        {
          if (i % 2 != 0)
          {
            soma = soma + i;
          }
        }
        Console.WriteLine(soma);
      }
      else
      {
        for (var i = x + 1; i < y; i++)
        {
          if (i % 2 != 0)
          {
            soma = soma + i;
          }
        }
        Console.WriteLine(soma);
      }
    }
  }
}