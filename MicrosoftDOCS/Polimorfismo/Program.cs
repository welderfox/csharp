using System;
using System.Collections.Generic;

namespace Polimorfismo
{
  class Program
  {
    static void Main(string[] args)
    {
      var formas = new List<Forma>
            {
                new Retangulo(),
                new Triangulo(),
                new Circulo(),
            };

      foreach (var forma in formas)
      {
        forma.desenho();
      }
      Console.WriteLine("Pessione Enter para encerrar a execução!");
      Console.ReadLine();
    }
  }
}
