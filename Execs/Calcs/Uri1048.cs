using System;
using System.Globalization;

namespace Execs
{
  class Uri1048
  {

    public static void SalaryInCrease()
    {
      double salario, valorDoReajuste, percentualReajuste, novoSalario;
      salario = float.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

      if (salario <= 400.00)
      {
        percentualReajuste = 15.0;
      }
      else if (salario > 400.00 && salario <= 800.00)
      {
        percentualReajuste = 12.0;
      }
      else if (salario > 800.00 && salario <= 1200.00)
      {
        percentualReajuste = 10.0;
      }
      else if (salario > 1200.00 && salario <= 2000.00)
      {
        percentualReajuste = 7.0;
      }
      else
      {
        percentualReajuste = 4.0;
      }

      valorDoReajuste = salario * percentualReajuste / 100;
      novoSalario = salario + valorDoReajuste;

      Console.WriteLine("Novo salário: " + novoSalario.ToString("F2", CultureInfo.InvariantCulture));
      Console.WriteLine("Ganho de reajuste: " + valorDoReajuste.ToString("F2", CultureInfo.InvariantCulture));
      Console.WriteLine("Em percentual: " + percentualReajuste.ToString("F0", CultureInfo.InvariantCulture) + " %");
    }
  }
}
