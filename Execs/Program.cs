using System;
using System.Globalization;

namespace Execs
{
  class Program
  {

    public static void Main(string[] args)
    {
      int numero;
      int fatorial = 0;
      numero = int.Parse(Console.ReadLine());
      var initialNumber = numero;
      while (numero != 1)
      {
        var fator = numero - 1;
        if (numero == initialNumber)
        {
          fatorial = numero * fator;
        }
        else
        {
          if (fator >= 1)
          {
            fatorial = fatorial * fator;
          }
          else
          {
            fatorial = fatorial * (fator - 1);
          }
        }
        numero--;
      }
      Console.WriteLine(fatorial);
      Console.ReadLine();
    }
  }
}