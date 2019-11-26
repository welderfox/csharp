using System;
using System.Globalization;

namespace Execs
{
  class Bhaskara
  {
    public void FormulaDeBhaskara(double a, double b, double c)
    {
      double x1, x2, delta;
      delta = Math.Pow(b, 2.0) - 4 * a * c;
      if (a == 0 || delta < 0.0)
      {
        Console.WriteLine("Impossível calcular!");
      }
      else
      {
        x1 = (-b + Math.Sqrt(delta)) / (2.0 * a);
        x2 = (-b - Math.Sqrt(delta)) / (2.0 * a);
        Console.WriteLine("R1= " + x1.ToString("F5", CultureInfo.InvariantCulture));
        Console.WriteLine("R2= " + x2.ToString("F5", CultureInfo.InvariantCulture));
      }
    }
  }
}