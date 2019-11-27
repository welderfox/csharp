using System;
using System.Globalization;

namespace Execs
{
  class Uri1038
  {

    public static void Snack()
    {
      string[] valores = Console.ReadLine().Split(' ');

      int X, Y;
      double total = 0;

      X = int.Parse(valores[0]);
      Y = int.Parse(valores[1]);

      if (X == 1)
      {
        total = Y * 4.00;
      }
      else if (X == 2)
      {
        total = Y * 4.50;
      }
      else if (X == 3)
      {
        total = Y * 5.00;
      }
      else if (X == 4)
      {
        total = Y * 2.00;
      }
      else if (X == 5)
      {
        total = Y * 1.50;
      }

      Console.WriteLine("Total: R$ " + total.ToString("F2", CultureInfo.InvariantCulture));
      Console.ReadLine();
    }
  }
}
