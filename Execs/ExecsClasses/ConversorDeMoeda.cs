namespace Execs
{
  class ConversorDeMoeda
  {
    public static double IOF = 0.06;

    public static double CotacaoDolar;

    public static double ValorAConverter;

    public static double Convercao(double cotacaoDolar, double valorAConverter)
    {
      var ValorAPagar = cotacaoDolar * valorAConverter;
      return ValorAPagar + (ValorAPagar * IOF);
    }
  }
}