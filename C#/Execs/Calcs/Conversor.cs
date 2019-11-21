using System;
namespace Execs
{
  class Conversor
  {
    public string Converter(int N)
    {
      var horas = N / 3600;
      var resto = N % 3600;
      var min = resto / 60;
      var segundos = resto % 60;

      var retorno = (horas + ":" + min + ":" + segundos);
      return retorno;
    }
  }
}