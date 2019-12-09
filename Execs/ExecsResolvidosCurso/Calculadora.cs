using System;
using System.Globalization;

namespace Execs
{
  class Calculadora
  {
    public static double PI = 3.14;

    public static double Circunferencia(double raio)
    {
      return 2 * PI * raio;
    }

    public static double Volume(double r)
    {
      return 4 / 3 * PI * Math.Pow(r, 3.0);
    }

  }
}
