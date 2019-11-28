using System;
using System.Globalization;

namespace Execs
{
  class Uri1046
  {

    public static void DuracaoJogo()
    {
      string[] valores = Console.ReadLine().Split(' ');
      int horaInicio, horaTermino, dia = 24, duracao;

      horaInicio = int.Parse(valores[0]);
      horaTermino = int.Parse(valores[1]);

      if (horaInicio == horaTermino)
      {
        Console.WriteLine("O JOGO DUROU 24 HORA(S)");
      }
      else if (horaInicio > horaTermino)
      {
        duracao = dia - horaInicio + horaTermino;
        Console.WriteLine("O JOGO DUROU " + duracao + " HORA(S)");
      }
      else
      {
        duracao = horaTermino - horaInicio;
        Console.WriteLine("O JOGO DUROU " + duracao + " HORA(S)");
      }
      Console.ReadLine();
    }
  }
}
