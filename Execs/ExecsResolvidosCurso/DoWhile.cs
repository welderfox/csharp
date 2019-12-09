using System;
using System.Globalization;

namespace Execs
{
  class DoWhile
  {
    public static void FacaEnquanto()
    {
      double c, f;
      char repetir;

      do
      {
        Console.Write("Digite a temperatura em Celsius: ");
        c = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

        f = 9.0 * c / 5.0 + 32.0;
        Console.WriteLine($"Equivalente em Fahrenheit {f.ToString("F1", CultureInfo.InvariantCulture)}");
        Console.Write("Deseja repetir (s/n)? ");
        repetir = char.Parse(Console.ReadLine());
      } while (repetir == 's');
    }
  }
}