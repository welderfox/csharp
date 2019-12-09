using System;
using System.Globalization;

namespace Execs
{
  class Uri1078
  {
    public static void Tabuada()
    {
      int N;
      N = int.Parse(Console.ReadLine());

      for (var i = 1; i <= 10; i++)
      {
        var resultado = i * N;
        Console.WriteLine($"{i} x {N} = {resultado}");
      }
    }
  }
}