using System;
using System.Globalization;

namespace Execs
{
  class Uri1051
  {

    public static void imposto()
    {
      double salario, imposto;
      salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
      if (salario <= 2000.00)
      {
        Console.WriteLine("Isento");
      }
      else if (salario > 2000.00 && salario <= 3000.00)
      {
        var after2000 = salario - 2000.00;
        imposto = after2000 * 0.08;
        Console.WriteLine($"R$ {imposto.ToString("F2", CultureInfo.InvariantCulture)}");
      }
      else if (salario > 3000.00 && salario <= 4500.00)
      {
        var after3000 = salario - 3000.00;
        imposto = (1000.00 * 0.08) + (after3000 * 0.18);
        Console.WriteLine($"R$ {imposto.ToString("F2", CultureInfo.InvariantCulture)}");
      }
      else
      {
        var after4500 = salario - 4500.00;
        imposto = (1000.00 * 0.08) + (after4500 * 0.28) + (1500.00 * 0.18);
        Console.WriteLine("R$ " + imposto.ToString("F2", CultureInfo.InvariantCulture));
      }
    }
  }
}