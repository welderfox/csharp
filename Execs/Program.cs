using System;
using System.Globalization;

namespace Execs
{
  class Program
  {

    public static void Main(string[] args)
    {
      string[] valores = Console.ReadLine().Split(' ');
      int horaInicio, minutoInicio, horaFim, minutoFim, duracaoHora, duracaoMinuto, diaEmMinutos = 1440;
      horaInicio = int.Parse(valores[0]);
      minutoInicio = int.Parse(valores[1]);
      horaFim = int.Parse(valores[2]);
      minutoFim = int.Parse(valores[3]);

      if ((horaInicio == horaFim) && (minutoInicio == minutoFim))
      {
        Console.WriteLine("O JOGO DUROU 24 HORA(S) E 0 MINUTO(S)");
      }
      else if ((horaInicio > horaFim) && (minutoInicio == minutoFim))
      {
        duracaoHora = 24 - horaInicio + horaFim;
        Console.WriteLine("O JOGO DUROU " + duracaoHora + " HORA(S) E 0 MINUTO(S)");
      }
      else if ((horaInicio > horaFim) && (minutoInicio > minutoFim))
      {
        duracaoHora = 24 - horaInicio + horaFim;
        duracaoMinuto = 60 - minutoInicio + minutoFim;
        Console.WriteLine("O JOGO DUROU " + duracaoHora + " HORA(S) E " + duracaoMinuto + " MINUTO(S)");
      }
      else if ((horaInicio < horaFim) && (minutoInicio > minutoFim))
      {
        duracaoHora = horaFim - horaInicio;
        duracaoMinuto = 60 - minutoInicio + minutoFim;
        Console.WriteLine("O JOGO DUROU " + duracaoHora + " HORA(S) E " + duracaoMinuto + " MINUTO(S)");
      }
      else if ((horaInicio < horaFim) && (minutoInicio < minutoFim))
      {
        duracaoHora = horaFim - horaInicio;
        duracaoMinuto = minutoFim - minutoInicio;
        Console.WriteLine("O JOGO DUROU " + duracaoHora + " HORA(S) E " + duracaoMinuto + " MINUTO(S)");
      }
    }
  }
}
