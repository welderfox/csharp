using System;

namespace Execs
{
  class Validation
  {

    public static void Validador()
    {
      string[] valores = Console.ReadLine().Split(' ');
      int A, B, C, D;
      A = int.Parse(valores[0]);
      B = int.Parse(valores[1]);
      C = int.Parse(valores[2]);
      D = int.Parse(valores[3]);


      if (B > C && D > A && C + D > A + B && C > 0 && D > 0 && A % 2 == 0)
      {
        Console.WriteLine("Valores aceitos");
      }
      else
      {
        Console.WriteLine("Valores nao aceitos");
      }
      Console.ReadLine();
    }
  }
}
