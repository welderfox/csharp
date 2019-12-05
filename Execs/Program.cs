using System;
using System.Globalization;

namespace Execs
{
  class Program
  {

    public static void Main(string[] args)
    {
      double salario, imposto;
      salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
      if (salario <= 2000.00)
      {
        Console.WriteLine("Isento");
      }
      else if (salario > 2000.00 && salario <= 3000.00)
      {
        imposto = salario * 0.08;
        Console.WriteLine("R$" + imposto);
      }
      else if (salario > 3000.00 && salario <= 4500.00)
      {
        var after3000 = salario - 3000.00;
        imposto = (1000.00 * 0.08) + (after3000 * 0.18);
        Console.WriteLine("R$ " + imposto.ToString("F2", CultureInfo.InvariantCulture));
      }
      else
      {
        var after4500 = salario - 4500.00;
        imposto = (2500.00 * 0.08) + (after4500 * 0.28);
        Console.WriteLine("R$ " + imposto.ToString("F2", CultureInfo.InvariantCulture));
      }

    }
  }
}