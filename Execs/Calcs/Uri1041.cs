using System;
using System.Globalization;

namespace Execs
{
  class Uri1041
  {

    public static void Cordenadas(string[] args)
    {
      double x, y;
      string[] valores = Console.ReadLine().Split(' ');
      x = double.Parse(valores[0], CultureInfo.InvariantCulture);
      y = double.Parse(valores[1], CultureInfo.InvariantCulture);

      if (x == 0.0 && y == 0.0)
      {
        Console.WriteLine("Origem");
      }
      else if (x > 0.0 && y > 0.0)
      {
        Console.WriteLine("Q1");
      }
      else if (x < 0.0 && y > 0.0)
      {
        Console.WriteLine("Q2");
      }
      else if (x < 0.0 && y < 0.0)
      {
        Console.WriteLine("Q3");
      }
      else if (x == 0.0)
      {
        Console.WriteLine("Eixo Y");
      }
      else if (y == 0.0)
      {
        Console.WriteLine("Eixo X");
      }
      else
      {
        Console.WriteLine("Q4");
      }
    }
  }
}
