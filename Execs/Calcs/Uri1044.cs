using System;

namespace Execs
{
  class Uri1044
  {

    public static void Multiples()
    {
      string[] valores = Console.ReadLine().Split(' ');
      int A, B;
      A = int.Parse(valores[0]);
      B = int.Parse(valores[1]);

      if (A % B == 0 || B % A == 0)
      {
        Console.WriteLine("Sao Multiplos");
      }
      else
      {
        Console.WriteLine("Nao sao Multiplos");
      }
      Console.ReadLine();
    }
  }
}
