using System;
using System.Globalization;

namespace Execs
{
  class Uri1047
  {

    public static void RangeTime()
    {
      string[] valores = Console.ReadLine().Split(' ');
      int horaInicio, minutoInicio, horaFim, minutoFim, duracaoHora, duracaoMinuto;
      horaInicio = int.Parse(valores[0]);
      minutoInicio = int.Parse(valores[1]);
      horaFim = int.Parse(valores[2]);
      minutoFim = int.Parse(valores[3]);

      if (horaInicio > 24 || horaFim > 24 || minutoInicio > 59 || minutoFim > 59 ||
        (horaInicio == 24 && minutoInicio != 0) || (horaFim == 24 && minutoFim != 0) || horaInicio < 0 || horaFim < 0 ||
        minutoInicio < 0 || minutoFim < 0)
      {
        return;
      }
      else if (horaFim == horaInicio && minutoFim == minutoInicio)
      {
        Console.WriteLine("O JOGO DUROU 24 HORA(S) E 0 MINUTO(S)");
      }
      else if (horaInicio > horaFim && minutoFim == minutoInicio)
      {
        duracaoHora = 24 - horaInicio + horaFim;
        duracaoMinuto = 0;
        Console.WriteLine("O JOGO DUROU " + duracaoHora + " HORA(S) E " + duracaoMinuto + " MINUTO(S)");
      }
      else if (horaInicio == horaFim && minutoInicio > minutoFim)
      {
        duracaoHora = 23;
        duracaoMinuto = 60 - minutoInicio + minutoFim;
        if (duracaoMinuto < 1)
        {
          return;
        }
        else
        {
          Console.WriteLine("O JOGO DUROU " + duracaoHora + " HORA(S) E " + duracaoMinuto + " MINUTO(S)");
        }
      }
      else if (horaInicio == horaFim && minutoInicio < minutoFim)
      {
        duracaoHora = 0;
        duracaoMinuto = minutoFim - minutoInicio;
        if (duracaoMinuto < 1)
        {
          return;
        }
        else
        {
          Console.WriteLine("O JOGO DUROU " + duracaoHora + " HORA(S) E " + duracaoMinuto + " MINUTO(S)");
        }
      }
      else if (horaInicio > horaFim && minutoInicio > minutoFim)
      {
        duracaoHora = 24 - horaInicio + horaFim - 1;
        duracaoMinuto = 60 - minutoInicio + minutoFim;
        if (duracaoHora > 24 || duracaoMinuto < 1)
        {
          return;
        }
        else
        {
          Console.WriteLine("O JOGO DUROU " + duracaoHora + " HORA(S) E " + duracaoMinuto + " MINUTO(S)");
        }
      }
      else if (horaInicio > horaFim && minutoInicio < minutoFim)
      {
        duracaoHora = 24 - horaInicio + horaFim + 1;
        duracaoMinuto = 60 - minutoFim + minutoInicio;
        if (duracaoHora > 24 || duracaoMinuto < 1)
        {
          return;
        }
        else
        {
          if (duracaoHora == 24 && duracaoMinuto < 60)
          {
            duracaoHora = 0;
            Console.WriteLine("O JOGO DUROU " + duracaoHora + " HORA(S) E " + duracaoMinuto + " MINUTO(S)");
          }
          else if (duracaoHora == 24 && duracaoMinuto >= 60)
          {
            duracaoHora = duracaoHora - 1;
            duracaoMinuto = duracaoMinuto - 60;
            Console.WriteLine("O JOGO DUROU " + duracaoHora + " HORA(S) E " + duracaoMinuto + " MINUTO(S)");
          }
          else
          {
            Console.WriteLine("O JOGO DUROU " + duracaoHora + " HORA(S) E " + duracaoMinuto + " MINUTO(S)");
          }
        }
      }
      else if (horaInicio < horaFim && minutoInicio > minutoFim)
      {
        duracaoHora = 24 - horaFim + horaInicio + 1;
        duracaoMinuto = 60 - minutoInicio + minutoFim;
        if (duracaoHora > 24 || duracaoHora < 0 || duracaoMinuto < 0)
        {
          return;
        }
        else
        {
          if (duracaoHora == 24 && duracaoMinuto < 60)
          {
            duracaoHora = 0;
            Console.WriteLine("O JOGO DUROU " + duracaoHora + " HORA(S) E " + duracaoMinuto + " MINUTO(S)");
          }
          else if (duracaoHora == 24 && duracaoMinuto >= 60)
          {
            duracaoHora = duracaoHora - 1;
            duracaoMinuto = 60 - duracaoMinuto;
            Console.WriteLine("O JOGO DUROU " + duracaoHora + " HORA(S) E " + duracaoMinuto + " MINUTO(S)");
          }
        }
      }
      else
      {
        duracaoHora = horaFim - horaInicio;
        duracaoMinuto = minutoFim - minutoInicio;
        if (duracaoHora > 24 || duracaoHora < 0 || duracaoMinuto < 0)
        {
          return;
        }
        else
        {
          if (duracaoHora == 24 && duracaoMinuto < 60)
          {
            duracaoHora = 0;
            Console.WriteLine("O JOGO DUROU " + duracaoHora + " HORA(S) E " + duracaoMinuto + " MINUTO(S)");
          }
          else if (duracaoHora == 24 && duracaoMinuto >= 60)
          {
            duracaoHora = duracaoHora - 1;
            duracaoMinuto = 60 - duracaoMinuto;
            Console.WriteLine("O JOGO DUROU " + duracaoHora + " HORA(S) E " + duracaoMinuto + " MINUTO(S)");
          }
          else
          {
            Console.WriteLine("O JOGO DUROU " + duracaoHora + " HORA(S) E " + duracaoMinuto + " MINUTO(S)");
          }
        }
      }
    }
  }
}