using System;

namespace Execs
{
  class Pessoas
  {
    public string Nome1;
    public int Idade1;
    public string Nome2;
    public int Idade2;

    public void PessoaMaisVelha()
    {
      if (Idade1 > Idade2)
      {
        Console.WriteLine($"Pessoa mais velha: {Nome1}");
      }
      else
      {
        Console.WriteLine($"Pessoa mais velha: {Nome2}");
      }
    }
  }
}